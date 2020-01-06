using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawning : MonoBehaviour
{
    public GameObject fruit;
    public Vector3[] spawnPoints;
    public int amount = 3;
    private int whereToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        whereToSpawn = Random.Range(0,spawnPoints.Length);
        for(int i = 0; i <= amount; i++)
        {
            Instantiate(fruit,spawnPoints[whereToSpawn],Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
