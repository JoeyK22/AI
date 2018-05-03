using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace GoneHome
{
    public class PatrolEnemy : MonoBehaviour
    {
        public Transform waypointGroup;
        public float movementSpeed = 5f;
        // Determines how close to switch to new waypoint
        public float closeness = 1f;

        private Transform[] waypoints;
        private int currentIndex = 0;

        private Vector3 spawnPoint;

        // Use this for initialization
        void Start()
        {
            // Make a copy of the starting position
            spawnPoint = transform.position;

            int length = waypointGroup.childCount;
            waypoints = new Transform[length];
            // for(initialization; condition; iteration) 
            for (int i = 0; i < length; i++)
            {
                waypoints[i] = waypointGroup.GetChild(i);
            }
        }

        // Update is called once per frame
        void Update()
        {
            // Get current waypoint
            Transform current = waypoints[currentIndex];

            // Move enemy in direction of current waypoint
            Vector3 position = transform.position;
            Vector3 direction = current.position - position; // Direction to travel in
            position += direction.normalized * movementSpeed * Time.deltaTime;
            // Apply new position to transform
            transform.position = position;

            // Check closeness of enemy to current waypoint
            float distance = Vector3.Distance(position, current.position);
            // Is the enemy close to the current waypoint?
            if (distance <= closeness)
            {
                // Switch to next waypoint
                currentIndex++;
            }

            // Is currentIndex greather than or equal to length
            if (currentIndex >= waypoints.Length)
            {
                // Loop back to start
                currentIndex = 0;
            }
        }

        public void Reset()
        {
            transform.position = spawnPoint; // Reset position
            currentIndex = 0; // Reset current waypoint
        }
    }
}


