using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowStop : MonoBehaviour
{
    public WindowInteraction windowScript;
    public GameObject window;
    private void Start()
    {
        windowScript = window.GetComponent<WindowInteraction>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "top" && !windowScript.canClose)
        {
            windowScript.translationDoor = new Vector3(0f, 0f, 0f);
            windowScript.canClose = true;
        }
        if (other.tag == "bottom" && windowScript.canClose)
        {
            windowScript.translationDoor = new Vector3(0f, 0f, 0f);
            windowScript.canClose = false;
        }
    }
}
