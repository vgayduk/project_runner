using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehaviour : MonoBehaviour
{

	public float speed;
	public float jumpForce;
	public int jumpCount;
	private int currentJumpCount;

	Rigidbody2D rb;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        currentJumpCount = jumpCount;
    }

    
    void Update() {
    	rb.velocity = new Vector2(speed, rb.velocity.y); 

    	if (Input.GetKeyDown(KeyCode.Space) && currentJumpCount != 0 ) {
    		rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    		currentJumpCount--;
    	}
    }

    void OnCollisionEnter2D(Collision2D obj) {
    	if (obj.gameObject.name == "platform shape") {
    		currentJumpCount = jumpCount;
    	}
    }
}
