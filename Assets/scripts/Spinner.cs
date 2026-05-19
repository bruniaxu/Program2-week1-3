using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float zMax;
    public float zMin;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Hi");
    

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += speed * Time.deltaTime;
        transform.eulerAngles = currentRotation;

        if (currentRotation.z > zMax)
        {
            Debug.Log("Crossing the upper threshold currentZ[" + currentRotation.z.ToString() + "] zMax[" + zMax.ToString() + "]");
            speed = -speed;
            //speed *= -1f;
        }
        if (currentRotation.z < zMin)
        {
            Debug.Log("Crossing the lower threshold");
            speed = -speed;
        }
    }
}
