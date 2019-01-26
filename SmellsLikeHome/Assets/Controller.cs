using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float speed = 5f;
    CharacterController player;
    public float sensitivity;
    public GameObject Camera;

    float moveFB;
    float moveLR;

    float rotX;
    float rotY;



    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity;

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        transform.Rotate(0, rotX, 0);
        Camera.transform.Rotate(rotY, 0, 0);
        movement = transform.rotation * movement;
        

        player.Move(movement * Time.deltaTime);
    }
}
