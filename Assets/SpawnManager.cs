using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyAnimals;

    const float xRange = 10;
    const float spawnPointZ = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            int randomAnimal = Random.Range(0, enemyAnimals.Length);            
            Instantiate(enemyAnimals[randomAnimal], new Vector3(Random.Range(-xRange, xRange), 0, spawnPointZ), enemyAnimals[randomAnimal].transform.rotation);
        }
        
    }
}
