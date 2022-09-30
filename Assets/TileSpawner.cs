using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField] int rowsNum;
    [SerializeField] int columnsNum;
    [SerializeField] List<GameObject> tileTypes;
    int[,] gridArray; 

    // Start is called before the first frame update
    void Start()
    {
        gridArray = new int[rowsNum, columnsNum];
        GenerateGrid();
        SpawnTiles();
    }

    void SpawnTiles()
    {
        for (int row = 0; row < rowsNum; row++)
        {
            for (int column = 0; column < columnsNum; column++)
            {
                GameObject tile = Instantiate(tileTypes[gridArray[row, column]]);
                tile.transform.position = new Vector3(row, 0, column);
            }
        }
    }

    void GenerateGrid()
    {
        for(int row = 0; row < rowsNum; row++)
        {
            for (int column = 0; column < columnsNum; column++)
            {
                gridArray[row, column] = Random.Range(0, tileTypes.Count);
            } 
        }
    }
}
