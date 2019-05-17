using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MovementParameter", menuName = "Data/Movement Param")]
public class MovementParameters : ScriptableObject
{
    [SerializeField]
    private float _value;
}