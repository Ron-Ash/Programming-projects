using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    public GameObject[] loot;
    
    void Start()
    {
        currentHealth = maxHealth;
    }

    void FixedUpdate()
    {
        if (currentHealth <= 0)
        {
            foreach(GameObject lootItems in loot)
            {
                Instantiate(lootItems, this.gameObject.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }

    }
}
