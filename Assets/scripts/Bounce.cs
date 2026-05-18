using UnityEngine;

public class Bounce : MonoBehaviour
{

    public float xSpeed;
    public float ySpeed;

    //xMax
    //xMin
    public float xMax;
    public float xMin;
    //yMAx
    //yMin
    public float yMax;
    public float yMin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;

        //When assigning a value to a float, we want to append "f" to the end
        newPosition.x += xSpeed*Time.deltaTime;
        newPosition.y += ySpeed*Time.deltaTime;

        transform.position = newPosition;

        if (newPosition.x > xMax)
        {
            //option 1
            //xSpeed = -xSpeed;
            //option 2
            xSpeed *= -1f;

        }

        if (newPosition.x < xMin)
        {
            //option 1
            //xSpeed = -xSpeed;
            //option 2
            xSpeed *= -1f;

        }

        if (newPosition.y > yMax)
        {
            //option 1
            //ySpeed = -ySpeed;
            //option 2
            ySpeed *= -1f;

        }

        if (newPosition.y < yMin)
        {
            //option 1
            //ySpeed = -ySpeed;
            //option 2
            ySpeed *= -1f;

        }

    }
}
