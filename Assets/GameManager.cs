using UnityEngine;
using UnityEngine.UI;

// track player score, pause menu, exit key
public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public int playerOneScore = 0;
    public int playerTwoScore = 0;
    public Text playerOneText;
    public Text playerTwoText;
    public BallScript ball;
    public GameObject winMenu;
    private Text winText;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            TogglePause();
        }

        if (Input.GetKey(KeyCode.Escape)) {
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
        if (playerOneScore > 9) {
            playerWon("Player One");
        }
        if (playerTwoScore > 9) {
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
        ball.ResetPosition();
        playerOneText.text = playerOneScore.ToString();
    }

    public void PlayerTwoScore()
    {
        playerTwoScore++;
        playerTwoText.text = playerTwoScore.ToString();
        ball.ResetPosition();
    }
}
