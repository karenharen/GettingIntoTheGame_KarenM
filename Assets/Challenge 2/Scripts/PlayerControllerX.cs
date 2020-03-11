using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float waitToSpawnTime = 3.0f;
    public float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog

        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(timer > waitToSpawnTime)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 0.0f;
            }
            
        }
    }


}
