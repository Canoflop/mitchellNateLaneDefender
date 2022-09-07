using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn3 : MonoBehaviour
{



public GameObject Enemy2;
public float ypos2;
public float xpos2;
bool waitTime2;
public int enemycount2;

// Start is called before the first frame update
void Start()
{
    StartCoroutine(SpawnEnemy2());
}

// Update is called once per frame
IEnumerator SpawnEnemy2()
{
    while (enemycount2 < 5)
    {
        if (waitTime2 == false)
        {
            yield return new WaitForSeconds(7.0f);
            waitTime2 = true;
        }
        else
        {
            ypos2 = Random.Range(3.6f, -4.6f);


            Instantiate(Enemy2, new Vector2(9.23f, ypos2), Quaternion.identity);
            yield return new WaitForSeconds(7.0f);

            enemycount2 += 1;
        }
    }
}
void Update()
{

}
}
