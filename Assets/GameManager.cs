using UnityEngine;

// track player score, pause menu, exit key
public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab)) {
            TogglePause();
        }

        if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
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
}
