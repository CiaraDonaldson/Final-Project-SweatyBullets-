using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody PlayerRb;
    public float jumpForce = 5f;
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            JumpUp();
        }
        if (Input.GetKey(KeyCode.S))
        {
            JumpDown();
        }
        if (Input.GetKey(KeyCode.A))
        {
            JumpLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            JumpRight();
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {

        }
        void JumpDown()
        {
            PlayerRb.AddForce(Vector3.down * jumpForce, ForceMode.Impulse);
        }
        void JumpUp()
        {
            PlayerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        void JumpLeft()
        {
            PlayerRb.AddForce(Vector3.left * jumpForce, ForceMode.Impulse);
        }
        void JumpRight()
        {
            PlayerRb.AddForce(Vector3.right * jumpForce, ForceMode.Impulse);
        }
    }
}
