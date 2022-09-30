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
        ZooPlayer();
    }

    public void ZooPlayer()
    {
        currentControls = "ZooPlayer";
        controls.Disable();
        controls.ZooPlayer.Enable();
    }

    public void ZooBuild()
    {
        currentControls = "ZooBuild";
        controls.Disable();
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
