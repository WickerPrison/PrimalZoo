using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public int tileType;
    public bool occupied;
    public Vector2 gridPosition;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] SpriteRenderer spriteRenderer;
    Collider2D tileCollider;

    public void OnSpawn()
    {
        spriteRenderer.sprite = sprites[tileType];
    }

    public void BecomeOccupied()
    {
        tileCollider.isTrigger = false;
    }
}
