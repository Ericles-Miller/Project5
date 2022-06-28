using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{   
    private float minSpeed = 12, maxSpeed = 16, maxTorque = 10, ySpawPos =-6;
    private Rigidbody TargetRB;

    // Start is called before the first frame update
    void Start()
    {
        TargetRB = GetComponent<Rigidbody>();
        TargetRB.AddForce(Vector3.up * Random.Range(12,16), ForceMode.Impulse);
        TargetRB.AddTorque(Random.Range(-10,10),Random.Range(-10,10),Random.Range(-10,10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4,4),6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

