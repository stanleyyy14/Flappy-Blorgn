using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    //public PipeMoveScript pipeMove;

    private void Start()
    {
        //pipeMove = GameObject.FindGameObjectWithTag("Pipe").GetComponent<PipeMoveScript>();
    }

    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString(); 
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    //public void gameSpeedUp()
    //{
    //    //if (playerScore > 5)
    //    //{
    //    //    pipeMove.pipeMoveSpeed = 10;
    //    //}
    //}
}
