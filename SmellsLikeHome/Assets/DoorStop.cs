using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStop : MonoBehaviour
{
    public DoorInteraction doorScript;
    public GameObject door;
    private void Start()
    {
        doorScript = door.GetComponent<DoorInteraction>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "top" && !doorScript.canClose)
        {
            doorScript.rotationDoor = new Vector3(0f, 0f, 0f);
            doorScript.canClose = true;
        }
        if (other.tag == "bottom" && doorScript.canClose)
        {
            doorScript.rotationDoor = new Vector3(0f, 0f, 0f);
            doorScript.canClose = false;
        }
    }
}
