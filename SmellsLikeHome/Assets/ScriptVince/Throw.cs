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
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = PlayerCam;
            beingCarried = true;
            //this.transform.rotation = new Quaternion (4, 5, 0);
        }
        
        if(beingCarried)
        {GetComponent<Rigidbody>().angularVelocity = new Vector3 (4, 0, 0);
            if(touched)
            {
                 GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
                
            }
            
            if(Input.GetMouseButtonDown(0))
            {
                 GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
             GetComponent<Rigidbody>().AddForce(PlayerCam.forward * throwForce);
            }
            else if (Input.GetMouseButtonDown(1))
            {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
            beingCarried = false;
            }
        }
    }
    
    void OnTriggerEnter()
    {
    
        if(beingCarried){
            touched = true;
        }
    }
}
