using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public bool DoorOpen;
    public float rotationTimer;
    public Vector3 rotationDoor;
    // Start is called before the first frame update
    void Start()
    {
        DoorOpen = false;
        rotationTimer = 1f;
        rotationDoor = new Vector3(0, 1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorOpen)
        {
            if (rotationTimer < 5f)
            {
                rotationTimer += Time.deltaTime;
            }
            else
            {
                if (rotationTimer < 7.5f)
                {
                    transform.Rotate(rotationDoor);
                    rotationTimer += Time.deltaTime;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 0));
                }

            }
        }
    }

    private IEnumerator DoorOpenDelay(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

    }
}
