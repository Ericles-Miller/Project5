using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // foi add para o restart do game 
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{   
    public List<GameObject> targets; //lista de prefabs --- no momento sao 4 
    //public GameObject[] targets2;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;
    public bool IsGameActive;
    
    // Start is called before the first frame update
    private float spawnRate=1.0f; // var de tempo para spwnar os prefabs 
    private int score;

    //button restart
    public Button restartButton;



    void Start()
    {   
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget(){
        while(IsGameActive) {
            yield return new WaitForSeconds(spawnRate);  // tempo de esperara para rodar os comandos abaixo 
             
             // funcao para gerar a pos entre o primeiro e ultimo elemento do vetor  
             int index = Random.Range(0, targets.Count);  // count -- conta a dimensao do vetor 
             Instantiate(targets[index]); // pega a posicao do vetor 
        }
    }
    public void UpdateScore(int scoreToAdd){
        score+= scoreToAdd;
        scoreText.text = "Score:" + score;
    }

    public void GameOver(){
        GameOverText.gameObject.SetActive(true);
        IsGameActive = false;
        restartButton.gameObject.SetActive(true);
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void startGame()
    {
        IsGameActive = true;
        score 0;
        
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }
            
}
