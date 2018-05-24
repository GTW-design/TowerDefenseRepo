using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public List<Transform> spawnPositions = new List<Transform>();
    //Declaring characterPrefab as an object
    public GameObject characterPrefab;
    //Declaring spawnpoint as an object
    public GameObject spawnPoint;
    public Vector3 randomSpawnPos;

	// Use this for initialization
	void Start () {

        InvokeRepeating("SpawnCharacter", 2, 2);
		
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    void SpawnCharacter ()
    {
        Transform randomSpawnPos = spawnPositions[Random.Range(0, spawnPositions.Count)];

        GameObject newCharacter = Instantiate(characterPrefab, randomSpawnPos.position, randomSpawnPos.rotation) as GameObject;
    }

     
}

