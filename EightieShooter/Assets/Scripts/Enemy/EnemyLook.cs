using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLook : MonoBehaviour
{
    GameObject playerO;
    Vector3 targetPosition;

    private void Start()
    {
        playerO = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        targetPosition = playerO.transform.position;
        transform.LookAt(targetPosition);
    }

}
