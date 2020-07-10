using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject track = GameObject.Find("SoundTrackInGame");
            Destroy(track);
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(0);
        }
    }
}
