using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour
{
    public float speed = 20;
    public float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 100 || transform.position.x < -100)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Patrol enemy = collision.GetComponent<Patrol>();
        if(enemy != null)
        {
            enemy.damage(damage);
        }
        FlyingEnemy enemy2 = collision.GetComponent<FlyingEnemy>();
        if (enemy2 != null)
        {
            enemy2.damage(damage);
        }
        if (collision.name != "SchmanWithGun")
        {
            Destroy(gameObject);
        }
        
    }
}
