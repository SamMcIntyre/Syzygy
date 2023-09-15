using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SlingerContoller : MonoBehaviour
{
	//declare public vars
	public Transform pTrans;
	public GameObject player;
	public LineRenderer chargeLine;

	//declare private vars
	PlayerController pc;
	Vector2 dragStartPos, dragEndPos;
	bool mouseDown = false;

	// Start is called before the first frame update
	void Start()
	{
		pc = player.GetComponent<PlayerController>();
		chargeLine.enabled = false;
	}

	// Update is called once per frame
	void Update()
	{
		//get mouse position (for potential later use)
		Vector2 mousePos = Mouse.current.position.ReadValue();

		//update line
		if(mouseDown == true){
			chargeLine.SetPosition(1, mousePos);
		}


		if (Mouse.current.leftButton.wasPressedThisFrame)
		{
			Debug.Log(mousePos);
			mouseDown = true;
			DragStart(mousePos);
		}

		if (Mouse.current.leftButton.wasReleasedThisFrame)
		{
			Debug.Log(mousePos);
			mouseDown = false;
			dragEndPos = mousePos;
		}
	}

	void DragStart(Vector2 mousePos){
		dragStartPos = mousePos;
		chargeLine.SetPosition(0, dragStartPos);
		chargeLine.SetPosition(1, new Vector2(3,3));
		chargeLine.enabled = true;
	}

}
