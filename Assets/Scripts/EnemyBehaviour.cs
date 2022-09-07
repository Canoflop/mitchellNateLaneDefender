using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehaviour : MonoBehaviour
{

    public Transform FirePos;
    public float speed = 2;
    public int totalHealth = 3;
    public int currentHealth;
    public Text HSText;
    public GameObject FireEffect;
    

  
    // Start is called before the first frame update
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Damage (int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("destroyed");
            
}
    }
   
    void Update()
    {
        transform.position += -transform.right * Time.deltaTime * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("projectile"))
        {
            
            Damage(1);
            Destroy(collision.gameObject);
            Debug.Log(" bullet colliding");
            Instantiate(FireEffect, FirePos.position, FirePos.rotation);
            Debug.Log(("Firing"));



        }
        if (collision.gameObject.CompareTag("barrier"))
        {

           
            Destroy(gameObject);
            
        

        }


    }
}
