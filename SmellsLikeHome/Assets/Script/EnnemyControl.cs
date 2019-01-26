using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnnemyControl : MonoBehaviour
{
    [SerializeField]
    Transform PiePosition;
    NavMeshAgent EnnemyNavMesh;
    public DoorInteraction doorScript;
    public WindowInteraction windowScript;
    public float speedNeighbor = 2f;
    private bool IsDeath = false;
    private float TimerDelete = 1f;

    private void Awake()
    {
        PiePosition = GameObject.FindGameObjectWithTag("Pie").transform;
    }

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

        if (IsDeath)
        {
            speedNeighbor = 0f;
            if (TimerDelete < 5f)
            {
                TimerDelete += Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    private void SetDestination()
    {
        if (PiePosition != null)
        {
            Vector3 targetVector = PiePosition.transform.position;
            EnnemyNavMesh.speed = speedNeighbor;
            EnnemyNavMesh.SetDestination(targetVector);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pie")
        {
            //Pie lose health
            Debug.Log("Miam!");
            Destroy(this.gameObject);
        }
        if (other.tag == "Object")
        {
            //Die
            IsDeath = true;
        }
        if (other.tag == "Door")
        {
            //Open door
            doorScript = other.GetComponent<DoorInteraction>();
            doorScript.DoorOpen = true;
        }
        if (other.tag == "Window")
        {
            //Open Window
            windowScript = other.GetComponent<WindowInteraction>();
            windowScript.WindowOpen = true;
        }
    }
}
