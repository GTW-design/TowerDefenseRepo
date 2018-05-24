using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject characterPrefab;
    public List<Character> characterList = new List<Character>();
    public List<Transform> spawnPointList = new List<Transform>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SpawnNewCharacter();
        }
		
	}

    void SpawnNewCharacter()
    {
        Transform selectedSpawnPoint = spawnPointList[Random.Range(0, spawnPointList.Count)];
        GameObject newDuck = Instantiate(characterPrefab, selectedSpawnPoint.position, selectedSpawnPoint.rotation);

        characterList.Add(newDuck.GetComponent<Character>());

    }

    void GetCharacterName()
    {
        int i = Random.Range(0, characterList.Count);

        Debug.Log("This character is called" + characterList[1].name);
    }
}

