using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    [SerializeField] int score;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] PlayerMovement playerMovement;

    public void updateScore()
    {
        score += 1;
        if (score == 20 && playerMovement.playerIsAlive)
        {
            winGame();
        }
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void quitGame()
    {
        SceneManager.LoadScene("Title Scene");
    }

    private void winGame()
    {
        SceneManager.LoadScene("End Scene");
    }

}
