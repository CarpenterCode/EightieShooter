using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    GameObject myManager, playerHealthNumber;
    int myHealth, timeCounter;
    bool isAlive = true;

    private void Start()
    {
        myManager = GameObject.FindGameObjectWithTag("GameManager");
        playerHealthNumber = GameObject.FindGameObjectWithTag("PlayerHealthNumber");
    }
    private void Update()
    {
        CheckHealth();
        if (this.gameObject.GetComponent<PlayerMove>().moveSpeed == 10)
        {
            CancelInvoke();
        }
    }


    public void CannotShoot()
    {
        this.gameObject.GetComponent<PlayerShoot>().enabled = false;
    }
    public void CanShoot()
    {
        this.gameObject.GetComponent<PlayerShoot>().enabled = true;
    }


    public void CannotMove()
    {
        this.gameObject.GetComponent<PlayerMove>().enabled = false;
    }
    public void CanMove()
    {
        this.gameObject.GetComponent<PlayerMove>().enabled = true;
    }

    public void BoostSpeeed(float value)
    {
        this.gameObject.GetComponent<PlayerMove>().moveSpeed += value;
    }
    public void ExitBoost(float value)
    {
        InvokeRepeating("DecreaseSpeed", 0, 0.1f);
    }
    void DecreaseSpeed()
    {
        if (this.gameObject.GetComponent<PlayerMove>().moveSpeed > 10)
        {
            this.gameObject.GetComponent<PlayerMove>().moveSpeed -= 0.5f;
        }
    }

    void CheckHealth()
    {
        int myHP = this.gameObject.GetComponent<PlayerHealth>().health;
        playerHealthNumber.GetComponent<Text>().text = myHP.ToString();
        if (myHP <= 0)
        {
            DeadPlayer();
        }
    }
    void DeadPlayer()
    {
        myManager.GetComponent<MyManager>().GameOver();
        Time.timeScale = 0;
    }
    public void TakeDamage(int dmg)
    {
        this.gameObject.GetComponent<PlayerHealth>().health -= dmg;
        PlayOnDamage();
    }
    void PlayOnDamage()
    {
        this.gameObject.GetComponent<PlayerSounds>().PlayHit();
    }

    public void PlayOnShot()
    {
        this.gameObject.GetComponent<PlayerSounds>().PlayShot();
    }

    public void Pause()
    {
        this.gameObject.GetComponent<PlayerMove>().enabled = false;
        this.gameObject.GetComponent<PlayerShoot>().canShoot = false;
        this.gameObject.GetComponentInChildren<PlayerLook>().enabled = false;
    }
    public void UnPause()
    {
        this.gameObject.GetComponent<PlayerMove>().enabled = true;
        this.gameObject.GetComponent<PlayerShoot>().canShoot = true;
        this.gameObject.GetComponentInChildren<PlayerLook>().enabled = true;
    }
}
