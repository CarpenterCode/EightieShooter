using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckEdge : MonoBehaviour
{
    [SerializeField] LayerMask groundMask;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Walls") 
        {
            this.gameObject.GetComponentInParent<EnemyScript>().CarryOn();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        this.gameObject.GetComponentInParent<EnemyScript>().StopWalking();
    }
}
