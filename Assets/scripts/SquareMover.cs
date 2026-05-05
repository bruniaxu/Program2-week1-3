using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.02f;
    //xMax
    //xMin
    public float xMax;
    public float xMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //We can get access to the transform component by typing "transform"

        //On the transform we can access the position which is a Vector3
        //Vector contains x y and z values grouped together
        //transform.position.x += 1f;

    

    }

    // Update is called once per frame
    void Update()
    {
    
        Vector3 newPosition = transform.position;

        //When assigning a value to a float, we want to append "f" to the end
        newPosition.x +=speed;

        transform.position = newPosition;

        if (transform.position.x > xMax) {
            //option 1
            speed = -speed;
            //option 2
            //speed *= -1f;
          
        }

        if (transform.position.x < xMin)
        {
            //option 1
            speed = -speed;
            //option 2
            //speed *= -1f;

        }
    }
}
