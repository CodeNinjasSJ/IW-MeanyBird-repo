using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spike Object for controlling the game")]
    public GameObject spikes;
    [Header("Default Height")]
    public float height;
    // Start is called before the first frame update
    void Start()
    {
transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void InstantiateObjects(){
        Instantiate(spikes, transform.position, transform.rotation);

    }
}
