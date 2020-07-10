using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartLevel : MonoBehaviour
{
    [SerializeField] int killAmmount;

    GameObject myManager;


    private void Awake()
    {
        myManager = GameObject.FindGameObjectWithTag("GameManager");
        killAmmount = myManager.GetComponent<CountScore>().scoreToWin;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CommenceLevel();
        }
    }

    void CommenceLevel()
    {
        Time.timeScale = 1;
        myManager.GetComponent<MyManager>().isPaused = false;
        this.gameObject.SetActive(false);
    }
}
