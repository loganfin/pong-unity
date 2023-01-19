using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public KeyCode pauseButton;
    public KeyCode exitButton;

    public int playerOneScore = 0;
    public int playerTwoScore = 0;
    public Text playerOneText;
    public Text playerTwoText;

    public Ball ball;

    public GameObject winMenu;
    public int winScore = 10;
    private Text winText;

    public void Update()
    {
        if (Input.GetKeyDown(pauseButton)) {
            TogglePause();
        }

        if (Input.GetKey(exitButton)) {
            Application.Quit();
        }

        CheckWinCondition();
    }

    public void playerWon(string winnerName)
    {
            Time.timeScale = 0f;
            winMenu.SetActive(true);
            winText = winMenu.GetComponentInChildren<Text>();
            winText.text = winnerName + " Wins! Press Enter To Replay";
            if (Input.GetKeyDown(KeyCode.Return)) {
                winMenu.SetActive(false);
                playerOneScore = 0;
                playerTwoScore = 0;
                playerOneText.text = playerOneScore.ToString();
                playerTwoText.text = playerTwoScore.ToString();
                Time.timeScale = 1f;
            }
    }

    public void CheckWinCondition()
    {
        if (playerOneScore > winScore-1) {
            playerWon("Player One");
        }
        if (playerTwoScore > winScore-1) {
            playerWon("Player Two");
        }
    }

    public void TogglePause()
    {
        if (pauseMenu.activeInHierarchy == true) {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }
        else {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void PlayerOneScore()
    {
        playerOneScore++;
        playerOneText.text = playerOneScore.ToString();
        ball.ResetPosition();
    }

    public void PlayerTwoScore()
    {
        playerTwoScore++;
        playerTwoText.text = playerTwoScore.ToString();
        ball.ResetPosition();
    }
}
