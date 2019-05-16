
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Forms.Movers
{
    public class MovingForms : MonoBehaviour
    {
        [SerializeField]
        private Transform _target;

        [SerializeField]
        private float _movementSpeed = 20f;

        float _distanceToTarget;

        private void Awake()
        {  

            _distanceToTarget = Vector3.Distance(_target.position, transform.position);
        }

        void Update()
        {           
            transform.Translate(-_target.transform.forward * _movementSpeed * Time.deltaTime);
        }
    }
    
}