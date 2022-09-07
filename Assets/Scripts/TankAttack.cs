using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour
{
    public Transform BulletPos;
    public GameObject Bullet;
    public GameObject Fire;
    public float time = 2.0f;
    public float timer; 
    // Updates after every frame
    private void Awake()
    {
        timer = Time.time;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if ( timer >= time)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                spawnBullet();
                timer = 1.5f;
            }
           
        }
        
      
    
    }
    void spawnBullet()
    {
        Instantiate(Bullet, BulletPos.position, BulletPos.rotation);
        Debug.Log(("Firing"));
        Instantiate(Fire, BulletPos.position, BulletPos.rotation);
        Debug.Log(("Firing"));
      

    }


}
