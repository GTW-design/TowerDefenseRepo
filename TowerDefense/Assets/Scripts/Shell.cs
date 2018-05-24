using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    //The amount of damage the shell will do when it hits
    public int damage = 20;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, 4f);
	}

    //Called when the Rigidbody hits something
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Character>().TakeDamage(damage);
        }
        Destroy(this.gameObject); 
    }


}
