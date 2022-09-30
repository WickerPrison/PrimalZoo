using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public int tileType;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnSpawn()
    {
        spriteRenderer.sprite = sprites[tileType];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
