using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField]
    private float _speed = 4f;


    // Start is called before the first frame update
    void Start()
    {
        // take the current position = new position (0, 0, 0)

        transform.position = new Vector3(0, 0, 0); // the first 0 is the x axis the second y axis the third for z axis  
    }



    // Update is called once per frame
    void Update()   // Translate moves the object in direction and the distance written out.       
    {
        //transform.Translate(new Vector3(1, 1, 0)); // This code is going to make the object move to the right/x axis without stopping every frame.
        
        // transform.Translate(Vector3.right * Time.deltaTime); // This code makes the object move one meter per second to the right

        float horizontalInput = Input.GetAxis("Horizontal"); // Horizontal h�mtar v�rdet som matchar med det i Input v�rdet som unity har som standard. 
        float verticalInput = Input.GetAxis("Vertical"); // Samma sak g�ller f�r det vertikala.


        Vector3 directon = new Vector3(horizontalInput, verticalInput, 0); // En variabel f�r Vector 3 som g�r det l�ttare att koda r�relsen med b�de det verticala och det horizontella tillsammans med  [SerializeField] f�ltet _speed

        transform.Translate(directon * _speed * Time.deltaTime);


        // if player position on the y is greater than 0
        // y position = 0

        if (transform.position.y >= 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }

        else if (transform.position.y <= -3.8f)
        {
            transform.position = new Vector3(transform.position.x, -3.8f, 0);
        }

        if (transform.position.x > 11.3f)
        {
            transform.position = new Vector3(-11, 0, 0);
        }

        else if (transform.position.x <= -11f)

        {
            transform.position = new Vector3(11, 0, 0);
        }
        // if player on the x > 11
        // x pos = -11
        // else if player on the x is less than -11
        // x pos = 11





        /*
        transform.Translate(Vector3.right * horizontalInput  * _speed * Time.deltaTime);

        transform.Translate(Vector3.up * verticalInput * _speed * Time.deltaTime);

        */



    }
}
