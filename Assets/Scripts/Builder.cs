using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Builder : MonoBehaviour
{
    [SerializeField] GameObject buildingPrefab;
    InputManager im;
    public string currentTool = "none";
    bool isClicked;

    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        im.controls.ZooBuild.LeftClick.performed += ctx => LeftClick();
        im.controls.ZooBuild.LeftClick.canceled += ctx => isClicked = false;
    }

    private void Update()
    {
        if (isClicked && currentTool == "Path")
        {
            ChangeTileType(0);
        }
    }

    void LeftClick()
    {
        isClicked = true;

        switch (currentTool)
        {
            case "Building":
                Instantiate(buildingPrefab);
                break;
        }
    }

    void ChangeTileType(int newtype)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
     
        if (hit.collider != null)
        {
            if (!hit.transform.gameObject.CompareTag("Tile"))
            {
                return;
            }
            TileScript tileScript = hit.transform.gameObject.GetComponent<TileScript>();
            tileScript.tileType = newtype;
            tileScript.OnSpawn();
        }
    }
}
