using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Builder : MonoBehaviour
{
    [SerializeField] GameObject buildingPrefab;
    [SerializeField] GameObject fencePrefab;
    InputManager im;
    public string currentTool = "none";
    bool isClicked;
    LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.FindGameObjectWithTag("GameManager").GetComponent<InputManager>();
        im.controls.ZooBuild.LeftClick.performed += ctx => LeftClick();
        im.controls.ZooBuild.LeftClick.canceled += ctx => isClicked = false;

        layerMask = LayerMask.GetMask("Tiles", "UI");
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

        TileScript tile = GetClickedOnTile();
        switch (currentTool)
        {
            case "Building":
                PlaceBuilding placeBuilding = Instantiate(buildingPrefab).GetComponent<PlaceBuilding>();
                placeBuilding.GetPlaced(tile);
                break;
            case "Fence":
                FenceScript fence = Instantiate(fencePrefab).GetComponent<FenceScript>();
                fence.PlaceFence(tile);
                break;
        }
    }

    TileScript GetClickedOnTile()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 10, layerMask);

        if (hit.collider != null)
        {
            TileScript tileScript = hit.transform.gameObject.GetComponent<TileScript>();
            return tileScript;
        }
        return null;
    }

    void ChangeTileType(int newtype)
    {
        TileScript tileScript = GetClickedOnTile();
        tileScript.tileType = newtype;
        tileScript.UpdateTile();
    }
}
