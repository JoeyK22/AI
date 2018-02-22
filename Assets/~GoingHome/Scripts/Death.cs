using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoingHome
{
    public class Death : MonoBehaviour
    {
        void Died()
        {
            print("the" + name + " has Died");
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.name == "Deathzone" || other.name == "Enemy")
            {
                Died();
            }
        }
    }
}
