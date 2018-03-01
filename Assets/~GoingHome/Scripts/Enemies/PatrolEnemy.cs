using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace GoingHome
{
    public class PatrolEnemy : MonoBehaviour
    {
        public Transform waypointGroup;
        public float movementSpeed = 5f;

        // Determines how close to switch to new waypoint
        public float closeness = 0.25f;

        private Transform[] waypoints;
        private int currentindex = 0;


        // Use this for initialization
        void Start()
        {
            int length = waypointGroup.childCount;
            waypoints = new Transform[length];
            for (int i = 0; i < length; i++)
            {
                waypoints[i] = waypointGroup.GetChild(i);
            }

        }

        // Update is called once per frame
        void Update()
        {
            Transform current = waypoints[currentindex];

            Vector3 position = transform.position;
            Vector3 direction = current.position - position;
            position += direction.normalized * movementSpeed * Time.deltaTime;

            transform.position = position;


            float distance = Vector3.Distance(position, current.position);
            if (distance <= closeness)
            {
                currentindex++;
            }

            if (currentindex >= waypoints.Length)
            {
                currentindex = 0;
            }
        }
    }
}


