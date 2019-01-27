using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject prefab;
    public float delayTime=2f;
    public float timeSpawn;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Spawn", 5f, repeatTime);
        timeSpawn = Random.Range(5f, 35f);
    }

    // Update is called once per frame
    void Update()
    {
        if (delayTime < timeSpawn)
        {
            delayTime += Time.deltaTime;
        }
        else {
            delayTime = 1f;
            timeSpawn = Random.Range(5f,20f);
            Instantiate(prefab, transform.position, Quaternion.identity);
        }

    }
}
