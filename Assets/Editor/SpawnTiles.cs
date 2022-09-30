using UnityEditor;
using UnityEngine;

public class SpawnTiles : EditorWindow
{
    int rowsNum;
    int columnsNum;
    //[SerializeField] List<GameObject tileTypes;
    int[,] gridArray;
    GameObject tilePrefab;
    GameObject tileHolder;

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

        if(GUILayout.Button("Spawn Tiles"))
        {
            gridArray = new int[rowsNum, columnsNum];
            GenerateGrid();
            SpawnTheTiles();
        }
    }

    void SpawnTheTiles()
    {
        tileHolder = new GameObject();
        tileHolder.name = "Tile Holder";

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
                tile.transform.position = new Vector3(row - Mathf.Floor(rowsNum / 2), 0, column - Mathf.Floor(columnsNum / 2));
                tile.transform.parent = tileHolder.transform;
            }
        }
    }

    void GenerateGrid()
    {
        for (int row = 0; row < rowsNum; row++)
        {
            for (int column = 0; column < columnsNum; column++)
            {
                gridArray[row, column] = Random.Range(0, 2);
            }
        }
    }
}
