using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public float health = 3;
    public float dazedTime;
    private float currentTime;
    public GameObject explosion;
    public AudioSource hurt;
    public AudioSource die;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            die.Play();
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    public void damage(float damageAmount)
    {
        if (health > 1)
        {
            hurt.Play();
        }
        health--;
    }
}
