using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float speed = 2f;
    CharacterController player;

    float moveFB;
    float moveLR;


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

        Vector3 movement = new Vector3(moveLR, 0, moveFB);
        movement = transform.rotation * movement;

        player.Move(movement * Time.deltaTime);
    }
}
