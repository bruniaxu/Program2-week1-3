using UnityEngine;

public class rotate : MonoBehaviour
{
    float zSpeed;

    float zMax;
    float zMin;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z += 30f * Time.deltaTime;
        transform.eulerAngles = currentRotation;

        if (transform.eulerAngles.z > zMax)
        {
            zSpeed *= -1f;

        }

        if (currentRotation.z < zMin)
        {
            zSpeed *= -1f;

        }
    }
}

