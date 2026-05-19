using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUpHeld = Keyboard.current.upArrowKey.isPressed;
        if (isUpHeld) 
        {
            //Vector3 currentPosition = transform.position;
            //currentPosition.y += moveSpeed;
            //transform.position = currentPosition;

            transform.position += transform.up * moveSpeed * Time.deltaTime;

        }
        bool isDownHeld = Keyboard.current.downArrowKey.isPressed;
        if (isDownHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
        if (isLeftHeld)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }
    }
}
