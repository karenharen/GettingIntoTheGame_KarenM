using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int upperOutOfBounds = 30;
        int lowerOutOfBounds = -6;

        if (transform.position.z >= upperOutOfBounds || transform.position.z <= lowerOutOfBounds)
        {
            Destroy(gameObject);
        }
    }
}
