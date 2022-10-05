using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public int tileType;
    public bool occupied;
    public Vector2 gridPosition;
    public List<TileScript> adjacencyList = new List<TileScript>();
    [SerializeField] List<Sprite> sprites;
    [SerializeField] SpriteRenderer spriteRenderer;
    Collider2D tileCollider;
    TileHolder tileHolder;
    public bool hasAttraction = false;

    private void Start()
    {
        tileCollider = GetComponent<Collider2D>();
        tileHolder = GetComponentInParent<TileHolder>();
        tileHolder.tileArray[(int)gridPosition.x, (int)gridPosition.y] = this;

        StartCoroutine(BuildAdjacencyList());

        if (tileType == 2)
        {
            BecomeOccupied();
        }
    }

    public void UpdateTile()
    {
        spriteRenderer.sprite = sprites[tileType];
    }

    public void BecomeOccupied()
    {
        tileCollider.isTrigger = false;
        occupied = true;
    }

    IEnumerator BuildAdjacencyList()
    {
        yield return new WaitForEndOfFrame();

        if(gridPosition.x > 0)
        {
            adjacencyList.Add(tileHolder.tileArray[(int)gridPosition.x - 1, (int)gridPosition.y]);
        }

        if(gridPosition.x < tileHolder.rows - 1)
        {
            adjacencyList.Add(tileHolder.tileArray[(int)gridPosition.x + 1, (int)gridPosition.y]);
        }

        if (gridPosition.y > 0)
        {
            adjacencyList.Add(tileHolder.tileArray[(int)gridPosition.x, (int)gridPosition.y - 1]);
        }

        if (gridPosition.y < tileHolder.columns - 1)
        {
            adjacencyList.Add(tileHolder.tileArray[(int)gridPosition.x, (int)gridPosition.y + 1]);
        }
    }
}
