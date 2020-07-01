using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Transform attackPos;
    public float attackRadius;
    public float timeBtwAttack;
    private float currentTime;
    public float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTime <= 0)
        {
            if(Input.GetKey("e"))
            {
                Collider2D[] enemiesAttacked = Physics2D.OverlapCircleAll(attackPos.position, attackRadius, LayerMask.GetMask("Enemy"));
                foreach(Collider2D enemy in enemiesAttacked)
                {
                    enemy.GetComponent<Patrol>().damage(damage);
                }
                currentTime = timeBtwAttack;
            }
        }else
        {
            currentTime -= Time.deltaTime;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRadius);
    }
}
