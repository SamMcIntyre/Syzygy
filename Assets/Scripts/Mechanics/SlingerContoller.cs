using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingerContoller : MonoBehaviour, IPointerClickHandler
{
	//declare public vars
	public Transform pTrans;
	public GameObject player;

	//declare private vars
	PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
		pc = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

	//Detect if a click occurs
    public void OnPointerClick(PointerEventData pointerEventData)
    {
	//Output to console the clicked GameObject's name and the following message. You can replace this with your own actions for when clicking the GameObject.
		Debug.Log(name + " Game Object Clicked!");
    }

}
