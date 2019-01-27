using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public bool DoorOpen;
    private bool canClose;
    public float rotationTimer;
    public Vector3 rotationDoor;

    public Transform player;
    public Transform PlayerCam;

    private bool hasPlayer = false;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        DoorOpen = false;
        rotationTimer = 3f;
        rotationDoor = new Vector3(0, 1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 4f)
        {
            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }

        if (hasPlayer && Input.GetMouseButtonDown(0) && canClose)
        {
            DoorOpen = false;
            rotationTimer = 1f;
            canClose = false;
        }
        if (DoorOpen)
        {
            if (rotationTimer < 8f)
            {
                rotationTimer += Time.deltaTime;
            }
            else
            {
                if (rotationTimer < 10f)
                {
                    transform.Rotate(rotationDoor);
                    rotationTimer += Time.deltaTime;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 0));
                    canClose = true;
                }
            }
        }
        else
        {
            if (rotationTimer < 3f)
            {
                transform.Rotate(-rotationDoor);
                rotationTimer += Time.deltaTime;
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, 0));
            }
        }
    }

    private IEnumerator DoorOpenDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

    }
}
