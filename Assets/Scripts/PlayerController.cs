using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravityMultiplier = 1f;
    private Rigidbody rb;
    private InputAction jumpAction;

    private bool isOnGrounded = false;
    public bool isGameOver = false;
    void Awake()
    {
        isGameOver = false;
        rb = GetComponent<Rigidbody>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.gravity *= gravityMultiplier; // f=ma
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered && isOnGrounded == true && isGameOver == false)
        {
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            isOnGrounded = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit" + collision.gameObject.name); 
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            isGameOver = true;
        }


    }
}
