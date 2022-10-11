using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 10;
    TileScript currentTile;
    SortingGroup sortingGroup;
    InputManager im;
    Vector2 moveDirection;
    LayerMask layerMask;
    [SerializeField] Animator frontAnimator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        im = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        im.controls.ZooPlayer.Walk.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        im.controls.ZooPlayer.Walk.canceled += ctx => moveDirection = Vector2.zero;

        sortingGroup = GetComponent<SortingGroup>();
        layerMask = LayerMask.GetMask("Tiles");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(moveDirection.x, moveDirection.y, 0).normalized * Time.deltaTime * 10;
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, 0) * speed;
        frontAnimator.SetFloat("Velocity", rb.velocity.magnitude);
        GetCurrentTile();
        sortingGroup.sortingOrder = (int)currentTile.gridPosition.x;
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
