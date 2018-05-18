using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //The W key is pressed to move character forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.2f);
        }
        //The S key is pressed to move character backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -0.2f);
        }
        //The A key is pressed to move character to the left
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-0.2f, 0, 0);
        }
        //The D key is pressed to move character to the right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0.2f, 0, 0);
        }
	}
}
