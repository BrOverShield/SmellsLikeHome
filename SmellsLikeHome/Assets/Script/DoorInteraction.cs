using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public bool DoorOpen;
    public bool canClose;
    private float timerActivate = 1f;
    public Vector3 rotationDoor;
    public Transform Door;

    public Transform player;
    public Transform PlayerCam;

    AudioSource audioSource;
    public AudioClip ouvrir;

    private bool hasPlayer = false;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        DoorOpen = false;
        audioSource = GetComponent<AudioSource>();
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
            rotationDoor = new Vector3(0f, -90f * Time.deltaTime, 0f);
            //audioSource.PlayOneShot(ouvrir);
        }

        if (DoorOpen && !canClose)
        {
            if (timerActivate < 8f)
            {
                timerActivate += Time.deltaTime;
            }
            else {
                rotationDoor = new Vector3(0f, 90f * Time.deltaTime, 0f);
                //audioSource.PlayOneShot(ouvrir);
            }
        }
        Door.transform.parent.Rotate(rotationDoor);
    }
}

