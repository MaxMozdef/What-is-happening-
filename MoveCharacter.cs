using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    //in character 
    [SerializeField] private Rigidbody2D characterRB;
    [SerializeField] private float movementSpeed, testmovementSpeed, jumpForce;
    [SerializeField] private Collider2D colliderGroundCheck;
    [SerializeField] public bool groundCheck;
    private Animator animator;
    private float moveInput, horizontalSpeed;
    [SerializeField] private bool sencorClicJump;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();
        FlipRightLeft();
        Jump();
        transform.Translate(horizontalSpeed, 0, 0);
        OnJump();
    }

    private void Move()
    {
        moveInput = Input.GetAxis("Horizontal");
        characterRB.velocity = new Vector2(moveInput * testmovementSpeed * Time.deltaTime, characterRB.velocity.y);
    }
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck == true)
        {
            characterRB.AddForce(transform.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }

    private void FlipRightLeft()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterRB.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterRB.transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            groundCheck = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            groundCheck = false;
        }
    }

    //sensor button character management 

    public void OnJump()
    {
        if (sencorClicJump == true && groundCheck == true)
        {
            characterRB.AddForce(transform.up * jumpForce * Time.deltaTime, ForceMode2D.Impulse);
            animator.SetTrigger("isJump");
            if (groundCheck == true)
            {
                animator.Play("Idle");
            }
        }
    }
    public void SensorClickBoolTrue()
    {
        sencorClicJump = true;
    }
    public void SensorClickBoolFalse()
    {
        sencorClicJump = false;
    }
    
    public void OnLeft()
    {
            horizontalSpeed = movementSpeed * Time.deltaTime;
            characterRB.transform.localRotation = Quaternion.Euler(0, 180, 0);
            animator.SetBool("isRuning", true);
    }
    public void OnRight()
    {
            horizontalSpeed = movementSpeed * Time.deltaTime;
            characterRB.transform.localRotation = Quaternion.Euler(0, 0, 0);
            animator.SetBool("isRuning", true);
    }
    
    public void OnStop()
    {
        horizontalSpeed = 0;
        animator.SetBool("isRuning", false);
    }
}
