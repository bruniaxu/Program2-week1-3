using UnityEngine;
using UnityEngine.InputSystem;


public class DuckyMovement : MonoBehaviour
{

    public Camera gameCamera;

    public Vector3 pointA;
    public Vector3 pointB;

    public float hover = 1.5f;
    public float speed = 1f;

    private float progress = 0f;
    private bool movingOtherPoint = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
}

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPosition = gameCamera.ScreenToWorldPoint(mouseScreenPosition);
        mouseWorldPosition.z = 0f;

        float xDiff = transform.position.x - mouseWorldPosition.x;
        float yDiff = transform.position.y - mouseWorldPosition.y;

        float distanceSquared = xDiff * xDiff + yDiff * yDiff;

        if (distanceSquared < hover * hover)
        {
            if (movingOtherPoint == true)
            {
                progress = progress + Time.deltaTime * speed;
            }
            else
            {
                progress = progress - Time.deltaTime * speed;
            }

            if (progress >= 1f)
            {
                progress = 1f;
                movingOtherPoint = false;
            }

            if (progress <= 0f)
            {
                progress = 0f;
                movingOtherPoint = true;
            }

            transform.position = Vector3.Lerp(pointA, pointB, progress);
        }
    }
}
