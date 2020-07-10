using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public bool isAttacking;

    [SerializeField] float timeBetween;
    [SerializeField] int damageValue, enemyValue;
    GameObject myManager;
    Coroutine attackRoutine;

    bool bugA;
    float bugT;
    float setBugT = 1.5f;

    private void Start()
    {
        myManager = GameObject.FindGameObjectWithTag("GameManager");
    }

    private void Update()
    {
        bugT -= Time.deltaTime;
        if (bugT <= 0)
        {
            bugA = true;
        }
    }

    public void TakeDamege(int damageValue)
    {
        this.gameObject.GetComponent<EnemyHealth>().health -= damageValue;
    }

    public void AddScore()
    {
        myManager.GetComponent<CountScore>().score += enemyValue;
    }

    public void StopWalking()
    {
        this.gameObject.GetComponent<EnemyMove>().canWalk = false;
    }
    public void CarryOn()
    {
        this.gameObject.GetComponent<EnemyMove>().canWalk = true;
    }

    public void StartAttacking()
    {
        if (bugA == true)
        {
            bugA = false;
            if (isAttacking == false)
            {
                attackRoutine = StartCoroutine(this.gameObject.GetComponent<EnemyAttack>().DealDamage(damageValue, timeBetween));
                isAttacking = true;
                bugT = setBugT;
            }
        }
    }
    public void StopAttacking()
    {
        if (isAttacking == true)
        {
        StopCoroutine(attackRoutine);
        isAttacking = false;
        }
    }
}
