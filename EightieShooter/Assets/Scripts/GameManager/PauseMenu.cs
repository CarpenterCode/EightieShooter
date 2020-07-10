using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PauseGame();
        }
    }
    void PauseGame()
    {
        pauseMenu.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().Pause();
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
    }

    public void ReturnGame()
    {
        pauseMenu.SetActive(false);
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>().UnPause();
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }
}
