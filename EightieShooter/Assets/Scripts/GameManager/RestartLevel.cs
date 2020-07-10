using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartScene();
        }
    }
    public void RestartScene()
    {
        int lvl = SceneManager.GetActiveScene().buildIndex;
        if (lvl == 1)
        {
            GameObject track = GameObject.Find("SoundTrackInGame");
            Destroy(track);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
