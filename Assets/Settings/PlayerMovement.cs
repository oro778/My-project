using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //player Movement
    public Rigidbody2D player;
    public float playerSpeed = 5f;
    public float horizontalMovement;
    public float verticalMovement;

    //player color changing
    public GameObject plr;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newVelocity = new Vector2(horizontalMovement * playerSpeed, verticalMovement * playerSpeed);
        player.linearVelocity = newVelocity;
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
        verticalMovement = context.ReadValue<Vector2>().y;
    }

    public void ColorChanger(GameObject plr)
    {
        
    }
}
