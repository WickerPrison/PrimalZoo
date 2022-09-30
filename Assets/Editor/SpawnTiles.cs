using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : EditorWindow
{
    int rowsNum = 10;
    int columnsNum = 10;
    //[SerializeField] List<GameObject tileTypes;
    int[,] gridArray;
    GameObject tilePrefab;
    GameObject tileHolder;
    bool useDirt = true;
    bool useGrass = true;
    bool useWater = true;
    List<bool> allTiles = new List<bool>();
    List<int> allowedTiles = new List<int>();

    [MenuItem("Tools/Spawn Tiles")]
    public static void ShowWindow()
    {
        GetWindow(typeof(SpawnTiles));
    }

    private void OnGUI()
    {
        tilePrefab = EditorGUILayout.ObjectField("Tile Prefab", tilePrefab, typeof(GameObject), false) as GameObject;
        rowsNum = EditorGUILayout.IntField("Number of Rows", rowsNum);
        columnsNum = EditorGUILayout.IntField("Number of Columns", columnsNum);

        GUILayout.Label("Allowed Tile Types", EditorStyles.boldLabel);
        useDirt = EditorGUILayout.Toggle("     Dirt Allowed", useDirt);
        useGrass = EditorGUILayout.Toggle("     Grass Allowed", useGrass);
        useWater = EditorGUILayout.Toggle("     Water Allowed", useWater);

        if(GUILayout.Button("Spawn Tiles"))
        {
            ChooseTileTypes();
            GenerateGrid();
            SpawnTheTiles();
        }
    }

    void GenerateGrid()
    {
        gridArray = new int[rowsNum, columnsNum];

        for (int row = 0; row < rowsNum; row++)
        {
            for (int column = 0; column < columnsNum; column++)
            {
                int index = Random.Range(0, allowedTiles.Count);
                gridArray[row, column] = allowedTiles[index];
            }
        }
    }

    void ChooseTileTypes()
    {
        allTiles.Clear();
        allowedTiles.Clear();
        allTiles.Add(useDirt);
        allTiles.Add(useGrass);
        allTiles.Add(useWater);

        for(int n = 0; n < allTiles.Count; n++)
        {
            if (allTiles[n])
            {
                allowedTiles.Add(n);
            }
        }
    }

    void SpawnTheTiles()
    {
        GameObject[] tileHolders = GameObject.FindGameObjectsWithTag("TileHolder");
        foreach(GameObject holder in tileHolders)
        {
            DestroyImmediate(holder);
        }

        tileHolder = new GameObject();
        tileHolder.name = "Tile Holder";
        tileHolder.tag = "TileHolder";

        foreach (Transform child in tileHolder.transform)
        {
            DestroyImmediate(child.gameObject);
        }

        for (int row = 0; row < rowsNum; row++)
        {
            for (int column = 0; column < columnsNum; column++)
            {
                TileScript tile = Instantiate(tilePrefab).GetComponent<TileScript>();
                tile.tileType = gridArray[row, column];
                tile.OnSpawn();
                tile.transform.position = new Vector3(row - Mathf.Floor(rowsNum / 2), column - Mathf.Floor(columnsNum / 2), 2);
                tile.transform.parent = tileHolder.transform;
            }
        }
    }
}
