using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    
    public Transform player;
    public Transform PlayerCam;
    public float throwForce = 10;
    bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if(dist <= 2.5f)
        {
            hasPlayer = true;
        }
        else{
            hasPlayer = false;
        }
        
        if ( hasPlayer && Input.GetButtonDown("Use"))
    }
}
