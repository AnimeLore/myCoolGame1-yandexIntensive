using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HingeJoint2D))]

public class DisconnectFromRope : MonoBehaviour
{
    private HingeJoint2D _playerJoint;
    private Rigidbody2D _ropeRigidbody;


    private void Start()
    {
        _playerJoint = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           _playerJoint.enabled = false;
        }
    }

}
