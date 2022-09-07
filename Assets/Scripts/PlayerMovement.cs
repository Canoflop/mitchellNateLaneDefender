using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
            float XMove = Input.GetAxis("Horizontal");
            Vector3 newPosX = transform.position;
         newPosX.x = Mathf.Clamp(newPosX.x, -8.33f, 8.33f);
        newPosX.x += XMove * Time.deltaTime * speed;
            transform.position = newPosX;

            float YMove = Input.GetAxis("Vertical");
            Vector3 newPosY = transform.position;
         
            newPosY.y += YMove * Time.deltaTime * speed;
            newPosY.y = Mathf.Clamp(newPosY.y, -4.39f, 4);
            transform.position = newPosY;

        
    }
}
