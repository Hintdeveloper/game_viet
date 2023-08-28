using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Player player;
    public Image healthBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Health(float hp, float maxHp)
    {
        healthBar.fillAmount = hp / maxHp;
    }

    public void ReduceHP(float damage)
    {

    }
}
