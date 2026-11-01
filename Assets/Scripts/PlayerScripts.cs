using UnityEngine;
using UnityEngine.InputSystem;




public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 3;
    public float normalSpeed = 3;
    public float boostSpeed = 5;
    public Rigidbody2D rb;
    void Start()
    {


    }




    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += Vector3.up * movementSpeed * Time.deltaTime;
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.position += Vector3.down * movementSpeed * Time.deltaTime;
        }
        
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            movementSpeed = boostSpeed;
            
        }
        else 
        {
            movementSpeed = normalSpeed;
        }

        

        if (transform.position.x > 9.5f)
        {
            Vector3 pos = transform.position;
            pos.x = -9.5f;
            transform.position = pos;
        }
        else if (transform.position.x < -9.5f)
        {
            Vector3 pos = transform.position;
            pos.x = 9.5f;
            transform.position = pos;
        }

        if (transform.position.y > 5f)
        {
            Vector3 pos = transform.position;
            pos.y = -5f;
            transform.position = pos;
        }

        else if (transform.position.y < -5f)
        {
            Vector3 pos = transform.position;
            pos.y = 5f;
            transform.position = pos;
        }
    }
}