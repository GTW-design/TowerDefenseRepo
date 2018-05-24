using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingSystem : MonoBehaviour {

    Tower tower;

    public LayerMask enemiesLayer;

    private float checkForEnemiesBuffer;
    private float checkForEnemiesBufferTime = .2f;

	// Use this for initialization
	void Start ()
    {
        tower = transform.parent.GetComponent<Tower>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (checkForEnemiesBuffer < Time.time)
        {
            checkForEnemiesBuffer = Time.time + checkForEnemiesBufferTime;
            CheckForEnemies();
        }
	}
    void CheckForEnemies()
    {
        //Gather all enemies within range
        //Collider[] hits = Physics.OverlapSphere(transform.position, tower.level[tower.currentLevel - 1].range, enemiesLayer);
    }
}

