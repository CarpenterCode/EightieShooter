using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] float delay;

    private void Start()
    {
        Destroy(this.gameObject, delay);
    }
}
