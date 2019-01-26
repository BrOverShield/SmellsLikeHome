using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowInteraction : MonoBehaviour
{
    public bool WindowOpen;
    private float translationTimer;
    private Vector3 translationDoor;
    // Start is called before the first frame update
    void Start()
    {
        WindowOpen = false;
        translationTimer = 1f;
        translationDoor = new Vector3(0,1f*Time.deltaTime,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (WindowOpen)
        {
            if (translationTimer < 5f)
            {
                translationTimer += 1f * Time.deltaTime;
            }
            else
            {
                if (translationTimer < 7.5f)
                {
                    transform.Translate(translationDoor);
                    translationTimer += 1f * Time.deltaTime;
                }
                else
                {
                    transform.Translate(new Vector3(0, 0, 0));
                }

            }
        }
    }
}
