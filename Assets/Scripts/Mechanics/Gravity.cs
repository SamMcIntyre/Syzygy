//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
	// Declare the public vars:
	public float mass = 1;
	public Transform pTrans;
	public GameObject player;

	// Declare the constants:
	const float G = 6.674E-11f; //universal gravitational constant;

	// Declare the private vars:
	private Vector2 diff = new Vector2(0,0);
	PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
		//System.Console.WriteLine("hiya");
		//Debug.Log("yo wtf");
		//print("huh?");
		print(G);
		print(pTrans.position.x);
		print(pTrans.position.y);

		diff.x = pTrans.position.x - this.transform.position.x;
		diff.y = pTrans.position.y - this.transform.position.y;

		print(diff);
		print(diff.magnitude);

		pc = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
		//print(pTrans.position.x);
		//print(pTrans.position.y);
		diff.x = pTrans.position.x - this.transform.position.x;
		diff.y = pTrans.position.y - this.transform.position.y;

		pc.feelGravity(diff);
    }

	// calculate effect of gravity with a calculateGravity function
	// send out an event if it is close enough to matter so that the player rigidbody runs the force calc
}
