using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceScript : MonoBehaviour
{
    

    public void PlaceFence(TileScript tile)
    {
        transform.position = tile.transform.position;
        tile.BecomeOccupied();
    }
}
