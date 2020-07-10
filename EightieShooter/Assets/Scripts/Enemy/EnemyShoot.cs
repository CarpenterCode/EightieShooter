using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float timeBetweenShots;

    Transform firePoint;

    private void Start()
    {
        firePoint = this.gameObject.GetComponentInChildren<Transform>();
        StartCoroutine(ShootPlayer());
    }

    IEnumerator ShootPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
