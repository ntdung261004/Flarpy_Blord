using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOver;

    public int highestScoreLogic = 0;
   


    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        
        playerScore = playerScore + scoreToAdd;     
        scoreText.text = playerScore.ToString();

        if (playerScore > highestScoreLogic)
        {
            highestScoreLogic = playerScore;
            Debug.Log(highestScoreLogic);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOver.SetActive(false);
    }

    public void gameOver()
    {
        GameOver.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }    
}
