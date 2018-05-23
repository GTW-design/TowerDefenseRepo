using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMe : MonoBehaviour {
    
    //The Speed the shell will travel
    public float shellSpeed = 20;

    //A reference to the shell prefab
    public GameObject shellPrefab;

    //A position where the shell will spawn at
    public Transform shellSpawnPoint;

    //Variable for turret rotational speed
    public float turretRotationalSpeed = 3f;

    //Reference for turret game object
    public GameObject turret;

    //References to the keys required to control the tank
    public KeyCode forwardsKey = KeyCode.W;
    public KeyCode backwardsKey = KeyCode.S;
    public KeyCode rotateLeftKey = KeyCode.A;
    public KeyCode rotateRightKey = KeyCode.D;
    public KeyCode rotateTurretLeftKey = KeyCode.Q;
    public KeyCode rotateTurretRightKey = KeyCode.E;
    public KeyCode fireKey = KeyCode.Space;

    //The health of the player
    public int health = 100;

    //Custom function that gets called when a shell hits
    public void TakeDamage(int damageToTake)
    {
        health = health - damageToTake;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (health <= 0)
        {
            //this exits the function and does not run anything after it.
            return;
        }

        //if the Q key is pressed the turret rotates left
        if (Input.GetKey(rotateTurretLeftKey))
        {
            turret.transform.Rotate(0, -turretRotationalSpeed, 0, Space.Self);
        }

        //if the E key is pressed the turret will rotate right
        if (Input.GetKey(rotateTurretRightKey))
        {
            turret.transform.Rotate(0, turretRotationalSpeed, 0, Space.Self);
        }

        //If the space key is pressed down then a shell will fire
        if (Input.GetKeyDown(fireKey))
        {
            GameObject GO = Instantiate(shellPrefab, shellSpawnPoint.position, Quaternion.identity) as GameObject;
            GO.GetComponent<Rigidbody>().AddForce(turret.transform.forward * shellSpeed, ForceMode.Impulse);
        }

        //The W key is pressed to move character forward
        if (Input.GetKey(forwardsKey))
        {
            transform.position = transform.position + new Vector3(0, 0, 0.2f);
        }
        //The S key is pressed to move character backward
        if (Input.GetKey(backwardsKey))
        {
            transform.position = transform.position + new Vector3(0, 0, -0.2f);
        }
        //The A key is pressed to move character to the left
        if (Input.GetKey(rotateLeftKey))
        {
            transform.position = transform.position + new Vector3(-0.2f, 0, 0);
        }
        //The D key is pressed to move character to the right
        if (Input.GetKey(rotateRightKey))
        {
            transform.position = transform.position + new Vector3(0.2f, 0, 0);
        }
	}
}
