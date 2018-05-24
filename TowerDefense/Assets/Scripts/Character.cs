using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public float speed;
    private Waypoints Wpoints;
    public int damage = 20;

    private int waypointIndex;

    //Health of the character
    public int health = 30;

    //Custom function that gets called when a shell hits the character
    public void TakeDamage(int damageToTake)
    {
        health = health - damageToTake;
    }

    //A reference to the shell prefab
    public GameObject shellPrefab;
    internal Vector3 position;
    internal readonly Quaternion rotation;

    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }
    private void Update()
    {
        if (health <=0)
        {
            Destroy(this.gameObject);
        }
        transform.position = Vector3.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        Vector3 dir = Wpoints.waypoints[waypointIndex].position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);

        if (Vector3.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
        {
            if (waypointIndex < Wpoints.waypoints.Length - 1)
            {
                waypointIndex++;
            }
            else
            {
                Destroy(gameObject);
            }
    
        }
    }
}
