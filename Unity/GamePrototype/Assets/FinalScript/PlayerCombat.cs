using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Transform attackPoint;
    public GameObject player;
    StatsManager statsManager;
    public LayerMask enemyLayers;
    public Collider2D[] hitEnemies;
    public float knucklesReach;

    void Start()
    {
        statsManager = player.GetComponent<StatsManager>();
    }


    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }


    void Attack()
    {
        hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, statsManager.weaponReach + knucklesReach, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            if(enemy.gameObject.GetComponent<EnemyHealth>())
            {
                enemy.gameObject.GetComponent<EnemyHealth>().currentHealth -= statsManager.Strength;
            }
            else
            {
                Destroy(enemy.gameObject);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, knucklesReach);
    }
}
