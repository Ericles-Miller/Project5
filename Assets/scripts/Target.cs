using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{   
    private float minSpeed = 12, maxSpeed = 16, maxTorque = 10, ySpawPos =-6,xRange=4;
    private Rigidbody TargetRB;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        TargetRB = GetComponent<Rigidbody>();
        TargetRB.AddForce(RandomForce(), ForceMode.Impulse);
        TargetRB.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawPos();

        //aplicando pontucao ao player ao destruir o target 
        gameManager = GameObject.Find("Game Object").GetComponent<GameManager>();
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

    //func para usar o mouse 
    private void OnMouseDown() {
        Destroy(gameObject);
        gameManager.UpdateScore(5);
    }


    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }
}

