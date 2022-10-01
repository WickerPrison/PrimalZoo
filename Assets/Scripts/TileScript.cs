using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public int tileType;
    public bool occupied;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] SpriteRenderer spriteRenderer;

    public void OnSpawn()
    {
        spriteRenderer.sprite = sprites[tileType];
    }

}
