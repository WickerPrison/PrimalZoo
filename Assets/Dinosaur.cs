using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinosaur : MonoBehaviour
{
    TileScript previousTile;
    TileScript nextTile;
    List<TileScript> possibleTiles = new List<TileScript>();
    bool moving;
    TileScript currentTile;
    MovableUnit movableUnit;
    float moveSpeed = 1;

    private void Start()
    {
        movableUnit = GetComponent<MovableUnit>();
        currentTile = movableUnit.GetCurrentTile(); 
    }

    private void Update()
    {
        Graze();
    }

    public void Graze()
    {
        if (!moving)
        {
            ChooseNextTile();
        }
        else
        {
            Vector2 moveDirection = nextTile.transform.position - transform.position;
            transform.Translate(moveDirection.normalized * Time.deltaTime * moveSpeed);
            if (Vector2.Distance(nextTile.transform.position, transform.position) < 0.1f)
            {
                previousTile = currentTile;
                currentTile = nextTile;
                moving = false;
            }
        }
    }

    void ChooseNextTile()
    {
        possibleTiles.Clear();
        foreach (TileScript tile in currentTile.adjacencyList)
        {
            if (tile.tileType == 1 && tile != previousTile && !tile.occupied)
            {
                possibleTiles.Add(tile);
            }
        }

        if (possibleTiles.Count != 0)
        {
            int randNum = Random.Range(0, possibleTiles.Count);
            nextTile = possibleTiles[randNum];
            moving = true;
        }
        else if (previousTile != null)
        {
            nextTile = previousTile;
            moving = true;
        }
    }
}
