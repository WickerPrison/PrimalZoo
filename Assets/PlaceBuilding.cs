using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlaceBuilding : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;
    SpriteRenderer spriteRenderer;
    TileHolder tileHolder;
    List<TileScript> myTiles = new List<TileScript>();
    List<TileScript> adjacencyList = new List<TileScript>();

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        tileHolder = GameObject.FindGameObjectWithTag("TileHolder").GetComponent<TileHolder>();
    }

    public void GetPlaced(TileScript centerTile)
    {
        spriteRenderer.sortingOrder = (int)centerTile.gridPosition.x + height - 1;
        Vector2 placementPosition = centerTile.transform.position;
        if(width%2 == 0)
        {
            placementPosition += new Vector2(0.5f, 0);
        }

        if(height%2 == 0)
        {
            placementPosition += new Vector2(0, 0.5f);
        }

        transform.position = placementPosition;

        int minCol = Mathf.CeilToInt(centerTile.gridPosition.y - width / 2) + 1;
        int maxCol = Mathf.FloorToInt(centerTile.gridPosition.y + width / 2);

        for(int column = minCol;column <= maxCol; column++)
        {
            myTiles.Add(tileHolder.tileArray[(int)centerTile.gridPosition.x, column]);
            tileHolder.tileArray[(int)centerTile.gridPosition.x, column].BecomeOccupied();
        }

        foreach(TileScript tile in myTiles)
        {
            foreach(TileScript adjacentTile in tile.adjacencyList)
            {
                if (!myTiles.Contains(adjacentTile))
                {
                    adjacencyList.Add(adjacentTile);
                    adjacentTile.hasAttraction = true;
                }
            }
        }
    }
}
