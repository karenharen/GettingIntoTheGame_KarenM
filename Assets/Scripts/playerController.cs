using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 10.0f;
    public GameObject projectile;

    const float horizontalBoundry = 10.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x > horizontalBoundry)
        {
            transform.position = new Vector3(horizontalBoundry, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -horizontalBoundry)
        {
            transform.position = new Vector3(-horizontalBoundry, transform.position.y, transform.position.z);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, projectile.transform.rotation);
        }

    }
}
