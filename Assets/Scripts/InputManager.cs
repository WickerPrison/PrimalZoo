using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] GameObject buildUI;
    [SerializeField] GameObject playerUI;
    Builder builder;
    public PlayerControls controls;
    public string currentControls;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.ZooPlayer.SwitchMode.performed += ctx => ZooBuild();
        controls.ZooBuild.SwitchMode.performed += ctx => ZooPlayer();
    }

    private void Start()
    {
        builder = GameObject.FindGameObjectWithTag("Builder").GetComponent<Builder>();
        ZooPlayer();
    }

    public void ZooPlayer()
    {
        currentControls = "ZooPlayer";
        controls.Disable();
        controls.ZooBuild.Disable();
        controls.ZooPlayer.Enable();
        playerUI.SetActive(true);
        buildUI.SetActive(false);
    }

    public void ZooBuild()
    {
        currentControls = "ZooBuild";
        controls.Disable();
        controls.ZooPlayer.Disable();
        controls.ZooBuild.Enable();
        buildUI.SetActive(true);
        playerUI.SetActive(false);
        builder.currentTool = "none";
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
