using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
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
        ZooPlayer();
    }

    public void ZooPlayer()
    {
        currentControls = "ZooPlayer";
        controls.Disable();
        controls.ZooBuild.Disable();
        controls.ZooPlayer.Enable();
    }

    public void ZooBuild()
    {
        currentControls = "ZooBuild";
        controls.Disable();
        controls.ZooPlayer.Disable();
        controls.ZooBuild.Enable();
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
