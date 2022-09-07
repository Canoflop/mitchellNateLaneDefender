using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
 
    public int maxHP = 3;
    public int currentHP;
    public GameObject player;

  
   
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

     void TakeDamage(int amount)
    {


        currentHP -= amount;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
            
            Debug.Log("destroyed");
        }
      
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            TakeDamage(1);
            
            

            Debug.Log("taking damage!");
            //enemies destroyed on impact to counteract losing 2 lives from enemy hitting tank then passing barrier
        }

        


    }
    
}


