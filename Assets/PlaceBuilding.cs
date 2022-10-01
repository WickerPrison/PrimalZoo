using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceBuilding : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
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
    }
}
