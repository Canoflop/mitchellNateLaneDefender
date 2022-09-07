using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject Enemy3;
    public float ypos3;
    public float xpos3;
    bool waitTime3;
    public int enemycount3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy3());
    }

    // Update is called once per frame
    IEnumerator SpawnEnemy3()
    {
        while (enemycount3 < 5)
        {
            if (waitTime3 == false)
            {
                yield return new WaitForSeconds(3.0f);
                waitTime3 = true;
            }
            else
            {
                ypos3 = Random.Range(3.6f, -4.6f);


                Instantiate(Enemy3, new Vector2(9.23f, ypos3), Quaternion.identity);
                yield return new WaitForSeconds(3.0f);

                enemycount3 += 1;
            }
        }
    }
    void Update()
    {

    }
}


    