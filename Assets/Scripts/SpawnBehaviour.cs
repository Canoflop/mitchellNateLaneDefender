using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    public GameObject Enemy;
    public float ypos;
    public float xpos;
    bool waitTime;
    public int enemycount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    IEnumerator SpawnEnemy()
    {
        while (enemycount < 5)
        {
            if (waitTime == false)
            {
                yield return new WaitForSeconds(10.0f);
                waitTime = true;
            }
            else
            {
                ypos = Random.Range(3.6f, -4.6f);


                Instantiate(Enemy, new Vector2(9.23f, ypos), Quaternion.identity);
                yield return new WaitForSeconds(10.0f);

                enemycount += 1;
            }
        }
    }
    void Update()
    {
        
    }
}
