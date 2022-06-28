using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
public class GameManager : MonoBehaviour
{   
    public List<GameObject> targets;
    public GameObject[] targets2;
    public TextMeshProUGUI scoreText;
    
    // Start is called before the first frame update
    private float spawnRate;
    private int score;


    void Start()
    {
        score = 0; 
        scoreText.text = "Score:" + scoreText;
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
