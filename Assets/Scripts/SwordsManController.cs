using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class SwordsManController : MonoBehaviour
{
    public PlayableDirector Time;
    public PlayableDirector Time2;
    public Animator anim;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public int maxJumpCount = 2;

    private int currentJumpCount = 0;
    private Rigidbody2D rb;

    private bool isJumping = false;
    private bool isGrounded = false;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.state == PlayState.Paused && Time2.state == PlayState.Paused)
        {
            IsRunning();
        }
    }
    public void IsRunning()
    {
        anim.SetBool("IsRunning", true);
        isGrounded = Physics2D.OverlapCircle(transform.position, 0.4f, LayerMask.GetMask("Ground"));

        // Move the character forward automatically
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        // Check for a double jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentJumpCount < maxJumpCount)
            {
                // Perform the jump
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                currentJumpCount++;
            }
        }

        // Reset the jump count when the character touches the ground
        if (isGrounded)
        {
            currentJumpCount = 0;
        }
    }
}
