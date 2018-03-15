using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace GoingHome
{
    public class Death : MonoBehaviour
    {

        public UnityEvent onDeath;

        void OnTriggerEnter(Collider other)
        {
            // Have we hit a 'DeathZone' OR 'Enemy'?
            if (other.name.Contains ("DeathZone") ||
                other.name.Contains ("Enemy"))
            {
                // KILL IT!
                onDeath.Invoke();
            }
        }
    }
}
