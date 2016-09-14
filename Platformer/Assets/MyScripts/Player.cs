using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    private Rigidbody2D rb;
    private float speed = 3;
    private bool grounded = false;
    private Animator animator;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y); //The second parameter allows him to fall while moving instead of flying.
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("isWalking", true);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("isWalking", true);

        }
        else
            animator.SetBool("isWalking", false);
        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 500));
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        grounded = true;
        Debug.Log("Collided");
    }
}
