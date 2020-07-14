using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{


     public Transform target;
void Update()
{
    //To make the HealthBar follow the player.
    transform.position = target.transform.position;
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
}
