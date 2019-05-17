using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Forms.Movers
{
    public class CollisionDetector : MonoBehaviour
    {
        [TagSelector]
        [SerializeField]
        private string _target = "";

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(_target))
            {
                Debug.Log("Just detected!");  
            }
        }
    }
}
