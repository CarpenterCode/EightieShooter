using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public bool canWalk = true;

    [SerializeField] float moveSpeed;

    Transform target;
    Rigidbody rb;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (canWalk)
        {
            MoveEnemy();
        }
    }

    void MoveEnemy()
    {
        rb.transform.position = Vector3.MoveTowards(rb.transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
