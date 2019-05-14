using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGameProject
{
    public class MovingForms : MonoBehaviour
    {

        [SerializeField]
        private float _movementSpeed = 20f;

        private Transform _myTransform;

        private void Start()
        {
            _myTransform = transform;
        }

        void Update()
        {
            _myTransform.Translate(Vector3.back * _movementSpeed * Time.deltaTime);
        }
    }
    
}