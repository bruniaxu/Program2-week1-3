using UnityEngine;
using UnityEngine.InputSystem;

//this script is to make the two coakatiels move between point A and Point B when the wand touches it 
public class DuckyMovement : MonoBehaviour
{
    //set public varaible
    public Camera gameCamera;
    //set two locations that the two parrots will move in
    public Vector3 pointA;
    public Vector3 pointB;
    //set the distance between the wand and the cockatiel before it starts moving 
    public float hover = 1.5f;
    //make a speed public variable to change the speed of how fast the parrot moves
    public float speed = 1f;

    private float progress = 0f;
    //set bool for detection to control the movement direction for the parrot
    private bool movingOtherPoint = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
}

    // Update is called once per frame
    void Update()
    {
        //get the mouse position in tha game world
        Vector3 mouseScreenPosition = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPosition = gameCamera.ScreenToWorldPoint(mouseScreenPosition);
        //the project is 2d so this make the position stays on the same 2d plane
        mouseWorldPosition.z = 0f;
        //calcualtes the distance between the parrot and the mosue 
        float xDiff = transform.position.x - mouseWorldPosition.x;
        float yDiff = transform.position.y - mouseWorldPosition.y;

        float distanceSquared = xDiff * xDiff + yDiff * yDiff;
        //if the mouse is close enough, the parrot will start moving
        //conditions
        if (distanceSquared < hover * hover)
        {
            if (movingOtherPoint == true)
            {//move to point B
                progress = progress + Time.deltaTime * speed;
            }
            else
            {// moving back to point A
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
            //make the parrot's moving from one point to another more smoothly
            transform.position = Vector3.Lerp(pointA, pointB, progress);
        }
    }
}
