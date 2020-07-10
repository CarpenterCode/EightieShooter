using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    
    Transform target;

    float aTimer;
    float setATimer;
    bool canAttack = true;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        aTimer -= Time.deltaTime;
        if (aTimer <= 0)
        {
            canAttack = true;
        }
    }


    public IEnumerator DealDamage(int dmg, float timeBetween)
    {
        while (true)
        {
            if (canAttack)
            {
                canAttack = false;
                aTimer = setATimer;
                target.GetComponent<PlayerScript>().TakeDamage(dmg);
                yield return new WaitForSeconds(timeBetween);
            }
        }

    }
}
