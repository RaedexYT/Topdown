﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //At the top of the script
 

public class HealthManager : MonoBehaviour

{
    

public Behaviour[] disableOnDeath;
   public float health;
    public Image healthbar; //Right before the void TakeDamage()
   
    public void TakeDamage(float amount)
        
{
       
        health -= amount;
    if (health <= 0)
    {
            healthbar.fillAmount = health / 100; //In the void TakeDamage()
            health = 0;
        Die();

    }
}
void Die()
{
    //Disable all the components inside the disableOnDeath array that you will assign from the inspector
    foreach (Behaviour behaviour in disableOnDeath)
    {
        behaviour.enabled = false;
    }
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
