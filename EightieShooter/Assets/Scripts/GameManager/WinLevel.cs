using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLevel : MonoBehaviour
{
    [SerializeField] Animator winAnimator, nextLevelAnimator;

    //OnCollision start loading level animation and load next scene after 1,5 s;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(NextLevel());
            other.gameObject.GetComponent<PlayerScript>().CannotMove();
        }
    }
        IEnumerator NextLevel()
    {
        nextLevelAnimator.SetTrigger("NextLevel");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Open floating gate to next level and stop spawning enemies and counting time;
    public void OpenGate()
    {
        winAnimator.SetTrigger("NextLevel");
        GameObject.FindGameObjectWithTag("EnemySpawner").GetComponent<EnemySpawner>().StopSpawning();
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<CountScore>().StopTimer();
    }
}
