using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Declare the public vars:
	public float mass = .05f;
	public float startVeloX = .75f;
	public float startVeloY = .25f;

	// Declare the private vars:
	private Rigidbody2D rb;// = GetComponent<Rigidbody2D>();
	private Transform trans;
	private float g = 0f; // acceleration due to gravity;
	private Vector2 normal; // normal vector of the acceleration direction
	bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(startVeloX, startVeloY);

		trans = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		//rb.velocity.x += g * normal.x;
		//rb.velocity.y += g * normal.y;
		if(!isGrounded){
			rb.velocity = new Vector2(rb.velocity.x + (g * normal.x), rb.velocity.y + (g * normal.y));
			//trans.Rotate(Vector3.forward, Vector2.Angle(rb.velocity, trans.up));
			//trans.eulerAngles = Vector3.forward * (Vector2.Angle(rb.velocity, Vector3.up));
			trans.eulerAngles = new Vector3(0,0,Vector2.SignedAngle(Vector2.up, rb.velocity));
		}
    }

	void OnCollisionEnter2D(Collision2D c){
		isGrounded = true;
		rb.velocity = new Vector2(0,0);
		print("ayo");
	}

	// calculate all added forces based on events that have been recieved. (sum them all to get a single force)
	public void feelGravity(Vector2 grav){
		//print(grav);
		g = -1f * (mass / (grav.magnitude * 10f)); //negative bc its gravity!!! (suck it in)
		normal = grav.normalized;
	}
	//make a fake addForce() function that will work with this kinematic rigidbody - directly change velo realistically with the given force
}
