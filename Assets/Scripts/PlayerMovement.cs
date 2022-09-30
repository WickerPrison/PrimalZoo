using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputManager im;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        im.controls.ZooPlayer.Walk.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        im.controls.ZooPlayer.Walk.canceled += ctx => moveDirection = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(moveDirection.x, 0, moveDirection.y).normalized * Time.deltaTime * 10;
    }
}
