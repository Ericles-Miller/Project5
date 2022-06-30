using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{   
    private float minSpeed = 12, maxSpeed = 16, maxTorque = 10, ySpawPos =-6,xRange=4;
    private Rigidbody TargetRB;
    public ParticleSystem explosionParticule;
    private GameManager gameManager;
    public int pointValue;
    

    // Start is called before the first frame update
    void Start()
    {
        TargetRB = GetComponent<Rigidbody>();
        TargetRB.AddForce(RandomForce(), ForceMode.Impulse);
        TargetRB.AddTorque(RandomTorque(),RandomTorque(),RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawPos();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();  
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
        if(gameManager.IsGameActive){
            Destroy(gameObject);
            Instantiate(explosionParticule, transform.position, explosionParticule.transform.rotation);
            gameManager.UpdateScore(pointValue);
        }
        

        
    }


    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        if(!gameObject.CompareTag("Bomb")){
            gameManager.GameOver();
        }
    }
}

