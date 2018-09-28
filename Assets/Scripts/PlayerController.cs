using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody2D rb;
    public float speed = 10;
    public float jumpForce = 500;
	// Use this for initialization
	void Start () {
        // hook up rb to game objecct
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(transform.position);
        //transform.position = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump")) {
            Debug.Log("Jump");
            rb.AddForce(Vector2.up* jumpForce);
        }
	}

   void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.name == "Speed Powerup")
        {
            speed = speed * 5;
            Destroy(col.gameObject);
        }
    }
}
