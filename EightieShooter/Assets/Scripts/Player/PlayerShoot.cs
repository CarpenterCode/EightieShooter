using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public bool canShoot = true;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform firePoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        this.gameObject.GetComponent<PlayerScript>().PlayOnShot();
    }
}
