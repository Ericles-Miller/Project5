using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   public List<GameObject> targets;
    public GameObject[] targets2;
    // Start is called before the first frame update
    private float spawnRate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget(){
        while( true) {
            yield return new WaitForSeconds(spawnRate);
             int index = Random.Range(0, targets.Count); //contador do object targets 
             Instantiate(targets[index]);
        }
        

    }
}
