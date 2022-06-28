using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{   
    private float minSpeed = 12, maxSpeed = 16, maxTorque = 10, ySpawPos =-6,xRange=4;
    private Rigidbody TargetRB;

    // Start is called before the first frame update
    void Start()
    {
        TargetRB = GetComponent<Rigidbody>();
        TargetRB.AddForce(RandomForce(), ForceMode.Impulse);
        TargetRB.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawPos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomForce(){
        return Vector3.up * Random.Range(minSpeed,maxSpeed);
    }

    float RandomTorque(){
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawPos(){
        return new Vector3(Random.Range(-xRange, xRange),ySpawPos);
    }
}

