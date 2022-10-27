using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableUnit : MonoBehaviour
{
    LayerMask layerMask;

    private void Start()
    {
        layerMask = LayerMask.GetMask("Tiles");
    }

    public TileScript GetCurrentTile()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, 10, layerMask);

        if (hit.collider != null)
        {
            TileScript tileScript = hit.transform.gameObject.GetComponent<TileScript>();
            return tileScript;
        }
        return null;
    }
}
