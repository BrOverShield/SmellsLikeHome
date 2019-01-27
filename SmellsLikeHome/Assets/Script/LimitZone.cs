using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitZone : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(prefab.GetComponent<Collider>(),GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
