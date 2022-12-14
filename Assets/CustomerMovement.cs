using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    TileScript previousTile;
    TileScript currentTile;
    TileScript nextTile;
    List<TileScript> possibleTiles = new List<TileScript>();
    bool moving = false;
    float moveSpeed = 1;
    bool viewingAttraction = false;
    MovableUnit movableUnit;

    // Start is called before the first frame update
    void Start()
    {
        movableUnit = GetComponent<MovableUnit>();
        currentTile = movableUnit.GetCurrentTile();
    }

    // Update is called once per frame
    void Update()
    {
        if (viewingAttraction)
        {
            return;
        }

        if (!moving)
        {
            if (currentTile.hasAttraction)
            {
                StartCoroutine(ViewAttraction());
            }
            else
            {
                ChooseNextTile();
            }
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

    IEnumerator ViewAttraction()
    {
        viewingAttraction = true;
        float viewTime = Random.Range(3, 10);
        yield return new WaitForSeconds(viewTime);
        viewingAttraction = false;
        ChooseNextTile();
    }

    void ChooseNextTile()
    {
        possibleTiles.Clear();
        foreach (TileScript tile in currentTile.adjacencyList)
        {
            if (tile.tileType == 0 && tile != previousTile && !tile.occupied)
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
