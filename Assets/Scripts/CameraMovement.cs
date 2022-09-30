using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform movePoint;
    [SerializeField] float cameraMoveSpeed;
    [SerializeField] float cameraFollowSpeed;
    InputManager im;
    Transform player;
    Vector3 offset;
    Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        im.controls.ZooBuild.MoveCamera.performed += ctx => moveDirection = ctx.ReadValue<Vector2>();
        im.controls.ZooBuild.MoveCamera.canceled += ctx => moveDirection = Vector2.zero;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        offset = movePoint.transform.position - player.position;
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        movePoint.transform.position = player.position + offset;
        if (im.currentControls == "ZooPlayer")
        {
            Vector3 moveDirection = movePoint.transform.position - transform.position;
            transform.position += moveDirection.normalized * cameraFollowSpeed * Time.deltaTime;
        }
        else if(im.currentControls == "ZooBuild")
        {
            transform.position += new Vector3(moveDirection.x, 0, moveDirection.y).normalized * Time.deltaTime * cameraMoveSpeed;
        }
    }
}
