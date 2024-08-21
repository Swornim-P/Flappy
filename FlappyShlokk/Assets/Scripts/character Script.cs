using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterScript : MonoBehaviour
{
    // bool isclicked; 
    //float height = 0.2f;
    float jumpForce = 12.0f;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetMouseButtonDown(0))
        {
            
            Jump();
            
        }
        else
        {
            animator.SetInteger("anim", 0);
        }
        //isclicked = false;

    }
    private void Jump()
    {
        animator.SetInteger("anim", 1);
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle");
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
