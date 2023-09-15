using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingerContoller : MonoBehaviour
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

}
