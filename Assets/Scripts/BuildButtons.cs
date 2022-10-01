using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildButtons : MonoBehaviour
{
    [SerializeField] GameObject buildOptions;
    Builder builder;

    // Start is called before the first frame update
    void Start()
    {
        builder = GameObject.FindGameObjectWithTag("Builder").GetComponent<Builder>();
        buildOptions.SetActive(false);
    }

    public void ShowBuildOptions()
    {
        if (buildOptions.activeSelf)
        {
            buildOptions.SetActive(false);
        }
        else
        {
            buildOptions.SetActive(true);
        }
    }

    public void Building()
    {
        builder.currentTool = "Building";
    }

    public void Path()
    {
        builder.currentTool = "Path";
    }

    private void OnEnable()
    {
        buildOptions.SetActive(false);
    }
}
