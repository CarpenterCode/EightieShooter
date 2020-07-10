using UnityEngine;

public class MyManager : MonoBehaviour
{
    public bool isPaused;
    [SerializeField] GameObject deadScreen;
    GameObject playerGO;

    private void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");
        Time.timeScale = 1;
    }

    private void Update()
    {
        CheckForStatus();
    }

    void CheckForStatus()
    {
        if (isPaused)
        {
            playerGO.GetComponent<PlayerScript>().CannotShoot();
        }
        else
        {
            playerGO.GetComponent<PlayerScript>().CanShoot();
        }
    }

    public void LevelWinMethod()
    {
        GameObject.FindGameObjectWithTag("LevelTrigger").GetComponent<WinLevel>().OpenGate();
    }

    public void GameOver()
    {
        deadScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
