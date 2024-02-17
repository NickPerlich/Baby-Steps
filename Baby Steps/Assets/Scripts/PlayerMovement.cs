using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float jumpStrenght = 3;
    private GameLogic gl;
    private bool playerIsAlive;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb.gravityScale = 0.5f;
        gl = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>();
        playerIsAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        // if space bar is press the player moves up
        if (Input.GetKeyDown(KeyCode.Space) && playerIsAlive) {
            rb.velocity = Vector2.up * jumpStrenght;
        }
        if (rb.velocity.y > 0)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gl.gameOver();
        playerIsAlive = false;
    }
}
