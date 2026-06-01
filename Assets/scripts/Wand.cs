using UnityEngine;
using UnityEngine.InputSystem;

public class Wand : MonoBehaviour
{
    //create public variables
    //set camera to make the wand visible on the game view
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get current mouse position 
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();
        //convert screen to world position coordinates
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
        //the project is 2d so this make the position stays on the same 2d plane
        worldMousePosition.z = 0f;
        //move the wand to the mouse position, transdorm.position is used to move the object
        transform.position = worldMousePosition;
    }
}
