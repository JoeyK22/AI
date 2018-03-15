using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



namespace GoneHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onGoal;

       void OnTriggerEnter(Collider other)
        {
            if(other.name.Contains("Player"))
            {
                onGoal.Invoke();
            }
        }
    }
}