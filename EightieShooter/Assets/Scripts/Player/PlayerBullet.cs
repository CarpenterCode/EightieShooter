using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField] GameObject bulletExplode;
    [SerializeField] float shotForce;
    [SerializeField] int minDamage, maxDamage;

    int dealDamage;
    Rigidbody rb;

    //Randomising damage, declaring rigidbody and shooting;
    private void Start()
    {
        dealDamage = Random.Range(minDamage, maxDamage);
        rb = this.gameObject.GetComponent<Rigidbody>();
        ShootForward();
    }

    //Shooting;
    void ShootForward()
    {
        rb.AddForce(transform.forward * shotForce * Time.deltaTime, ForceMode.Impulse);
    }

    //Check collision and behave acoording to it;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyScript>().TakeDamege(dealDamage);
            Instantiate(bulletExplode, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }

        if (other.tag != "PlayerBullet" && other.tag != "Player")
        {
            Instantiate(bulletExplode, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
