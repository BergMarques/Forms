
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Forms.Movers
{
    public class MovingForms : MonoBehaviour
    {
        [SerializeField]
        private float _movementSpeed = 20f;

        void Update()
        {           
            transform.Translate(-transform.forward * _movementSpeed * Time.deltaTime);            
        }

        private void OnBecameInvisible()
        {
            gameObject.SetActive(false);
        }
    }
    
}