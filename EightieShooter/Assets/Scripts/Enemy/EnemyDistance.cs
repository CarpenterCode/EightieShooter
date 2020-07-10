using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistance : MonoBehaviour
{
    [SerializeField] float stoppingDistance;
    [SerializeField] bool isRanged;
    float myT;

    Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    private void Update()
    {
        CheckDistanceFromPlayer();
    }

    void CheckDistanceFromPlayer()
    {
        if (Vector3.Distance(transform.position, target.position) < stoppingDistance)
        {
            this.gameObject.GetComponent<EnemyScript>().StopWalking();
            if (isRanged == false)
            {
                this.gameObject.GetComponent<EnemyScript>().StartAttacking();
            }
        }
        else
        {
            this.gameObject.GetComponent<EnemyScript>().CarryOn();
            this.gameObject.GetComponent<EnemyScript>().StopAttacking();
        }
    }
}
