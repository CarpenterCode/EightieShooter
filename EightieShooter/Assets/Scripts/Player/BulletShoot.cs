using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    [SerializeField] bool isPlayerBullet;
    [SerializeField] Bullet bullet = new Bullet();

    int dealDamage;
    Rigidbody rb;

    private void Start()
    {
        dealDamage = Random.Range(bullet.minDamage, bullet.maxDamage);
        rb = this.GetComponent<Rigidbody>();
        ShootForward();
    }

    void ShootForward()
    {
        rb.AddForce(transform.forward * bullet.shotSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (isPlayerBullet)
        {
            if (other.tag == "Enemy")
            {
                other.gameObject.GetComponent<EnemyScript>().TakeDamege(dealDamage);
                Instantiate(bullet.bulletExplosion, transform.position, transform.rotation);
                Destroy(this.gameObject);
            }

            if (other.tag != "PlayerBullet" && other.tag != "Player")
            {
                Instantiate(bullet.bulletExplosion, transform.position, transform.rotation);
                Destroy(this.gameObject);
            }
        }
        else
        {
            if (other.tag == "Player")
            {
                other.gameObject.GetComponent<PlayerScript>().TakeDamage(dealDamage);
                Instantiate(bullet.bulletExplosion, transform.position, transform.rotation);
                Destroy(this.gameObject);
            }
            
            if (other.tag != "EnemyBullet" && other.tag != "Enemy")
            {
                Instantiate(bullet.bulletExplosion, transform.position, transform.rotation);
                Destroy(this.gameObject);
            }
        }
    }
}
