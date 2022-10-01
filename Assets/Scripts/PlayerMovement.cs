using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    TileScript currentTile;
    SpriteRenderer spriteRenderer;
    InputManager im;
    Vector2 moveDirection;
    LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        im.controls.ZooPlayer.Walk.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        im.controls.ZooPlayer.Walk.canceled += ctx => moveDirection = Vector2.zero;

        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        layerMask = LayerMask.GetMask("Tiles");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveDirection.x, moveDirection.y, 0).normalized * Time.deltaTime * 10;
        GetCurrentTile();
        spriteRenderer.sortingOrder = (int)currentTile.gridPosition.x;
    }

    void GetCurrentTile()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, 10, layerMask);
        if (hit.collider != null)
        {
            currentTile = hit.transform.gameObject.GetComponent<TileScript>();
        }
    }
}
