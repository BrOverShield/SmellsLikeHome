using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject prefab;
    public float repeatTime = 15f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 5f, 15f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
