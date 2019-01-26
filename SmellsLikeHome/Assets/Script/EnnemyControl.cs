using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnnemyControl : MonoBehaviour
{
    [SerializeField]
    Transform PlayerPosition;
    NavMeshAgent EnnemyNavMesh;
    // Start is called before the first frame update
    void Start()
    {
        EnnemyNavMesh = this.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (EnnemyNavMesh == null)
        {
            Debug.LogError("The nav mesh agent component is not attached to " + EnnemyNavMesh);
        }
        else
        {
            SetDestination();
        }
    }
    private void SetDestination()
    {
        if (PlayerPosition != null)
        {
            Vector3 targetVector = PlayerPosition.transform.position;
            EnnemyNavMesh.SetDestination(targetVector);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pie")
        {
            //Lose health
        }
        if (other.tag == "Object") {
            //Die
        }
    }
}
