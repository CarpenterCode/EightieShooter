using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject enemyExplode, explodeSound0, explodeSound1, explodeSound2;

    public int health;

    private void Update()
    {
        if (health <= 0)
        {
            this.gameObject.GetComponent<EnemyScript>().AddScore();
            Instantiate(enemyExplode, transform.position, transform.rotation);
            SpawnSound();
            Destroy(this.gameObject);
        }
    }

    void SpawnSound()
    {
        int randSound = Random.Range(0, 2);
        switch (randSound)
        {
            case 0:
                Instantiate(explodeSound0, transform.position, transform.rotation);
                break;
            case 1:
                Instantiate(explodeSound1, transform.position, transform.rotation);
                break;
            case 2:
                Instantiate(explodeSound2, transform.position, transform.rotation);
                break;
        }
    }
    
}
