using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowInteraction : MonoBehaviour
{
    public bool WindowOpen;
    private bool canClose;
    private float translationTimer;
    private Vector3 translationDoor;

    public Transform player;
    public Transform PlayerCam;

    private bool hasPlayer = false;
    private bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        WindowOpen = false;
        canClose = false;
        translationTimer = 3.5f;
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
            WindowOpen = false;
            translationTimer = 1f;
            canClose = false;
        }

        if (WindowOpen)
        {
            translationDoor = new Vector3(0, 1f * Time.deltaTime, 0);
            if (translationTimer < 8f)
            {
                translationTimer += Time.deltaTime;
            }
            else
            {
                if (translationTimer < 9.5f)
                {
                    transform.Translate(translationDoor);
                    translationTimer += Time.deltaTime;
                }
                else
                {
                    transform.Translate(new Vector3(0, 0, 0));
                    canClose = true;
                }

            }
        }
        else {
            translationDoor = new Vector3(0, -1f * Time.deltaTime, 0);
            if (translationTimer < 3.5f)
            {
                transform.Translate(translationDoor);
                translationTimer += Time.deltaTime;
            }
            else
            {
                transform.Translate(new Vector3(0, 0, 0));
            }
        }
    }
}
