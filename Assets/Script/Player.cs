using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float HP = 200;
    public float maxHP = 200;
    public PlayerHealthBar healthBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReduceHP(float damege)
    {
        HP -= damege;
        healthBar.Health(HP, maxHP);

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
