using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;

    [SerializeField] CharacterController myControler;
    [SerializeField] float groundDistance, gravity, jumpHeight;
    [SerializeField] LayerMask groundedLayer;
    [SerializeField] Transform groundCheck;

    bool isGrounded;
    float x, z;
    Vector3 move;
    Vector3 velocity;

    private void Update()
    {
        CheckIfGrounded();
        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }


    void MovePlayer()
    {
        //Movement
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        move = transform.right * x + transform.forward * z;
        myControler.Move(move * moveSpeed * Time.deltaTime);
        
        //Gravity
        velocity.y += gravity * Time.deltaTime;
        myControler.Move(velocity * Time.deltaTime);
    }

    void CheckIfGrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundedLayer);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
    }

    void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }
}
