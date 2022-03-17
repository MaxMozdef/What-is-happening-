using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    //in character 
    [SerializeField] private Rigidbody2D characterRB;
    [SerializeField] private float movementSpeed, jumpForce;
    [SerializeField] private Collider2D colliderGroundCheck;
    private float moveInput;
    [SerializeField] private bool groundCheck;

    private void FixedUpdate()
    {
        Move();
        FlipRightLeft();
    }

    private void Update()
    {
        Jamp();
    }

    private void Move()
    {
        moveInput = Input.GetAxis("Horizontal");
        characterRB.velocity = new Vector2(moveInput * movementSpeed, characterRB.velocity.y);
    }

    private void Jamp()
    {
        if (Input.GetKeyDown(KeyCode.Space) & groundCheck == true)
        {
            characterRB.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
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
}
