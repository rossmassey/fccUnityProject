using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{

    public GameObject[] monsterReference;
    public Transform leftPos, rightPos;
    public float spawnHeight = 1;
    public Vector2 spawnTimeRange = new Vector2(1, 5);
    public Vector2 speedRange = new Vector2(4, 10);

    private GameObject spawnedMonster;

    private int randomIndex;
    private int randomSide;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while(true)
        {
            yield return new WaitForSeconds(
                Random.Range(spawnTimeRange.x, spawnTimeRange.y)
            );

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            // LEFT
            if (randomSide == 0)
            {
                spawnedMonster.transform.position = new Vector2(leftPos.transform.position.x, spawnHeight);
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(speedRange.x, speedRange.y);
            }
            // RIGHT
            else
            {
                spawnedMonster.transform.position = new Vector2(rightPos.transform.position.x, spawnHeight);
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(speedRange.x, speedRange.y);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
