using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

[ExecuteAlways]
public class SmokeController : MonoBehaviour
{
    WorldManager wm;
    void Start()
    {
        wm = FindObjectOfType<WorldManager>();
        Debug.Log(GetComponent<VisualEffect>());
    }

    void Update()
    {
        GetComponent<VisualEffect>().SetVector3("windDirection", wm.windDirection);
    }
}
