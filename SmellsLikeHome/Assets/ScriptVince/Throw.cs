using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    
    public Transform player;
    public Transform PlayerCam;
    public float throwForce = 10;
   private bool hasPlayer = false;
    bool beingCarried = false;
    private bool touched = false;

    AudioSource audioSource;

    public AudioClip prendre;
    public AudioClip lancer;

    public Material Floor;
    public Material mat2;
    
    // Start is called before the first frame update
    void Start()
    {
         GetComponent<Renderer>().material = Floor;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if(dist <= 4f)
        {
         hasPlayer = true;
       }
        else{
            hasPlayer = false;
       }
        
       
        
        if (hasPlayer && Input.GetMouseButtonDown(0))
        {

            //audioSource.PlayOneShot(prendre);
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = PlayerCam;
            beingCarried = true;
            GetComponent<Renderer>().material = mat2;
          
           
                
            
        }
        
        if(beingCarried)
        {GetComponent<Rigidbody>().angularVelocity = new Vector3 (0, -4, 1);
         
         this.transform.Rotate( 0.1f, 0.05f, 0.1f);
         
            if(touched)
            {
                 GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
                GetComponent<Renderer>().material = Floor;
            }
            
            if(Input.GetMouseButtonUp(0))
            {
                 GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Rigidbody>().AddForce(PlayerCam.forward * throwForce);
                GetComponent<Renderer>().material = Floor;
                //audioSource.PlayOneShot(lancer);
            }
            else if (Input.GetMouseButtonDown(1))
            {
             GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                GetComponent<Renderer>().material = Floor;
             //audioSource.PlayOneShot(lancer);
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
