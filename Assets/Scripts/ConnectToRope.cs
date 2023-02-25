using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectToRope : MonoBehaviour
{
    private BoxCollider2D _collider;
    private HingeJoint2D _playerJoint;
    private Rigidbody2D _rigidBody;
    
    private void Start()
    {
        _collider = GetComponent<BoxCollider2D>();
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.TryGetComponent(out MoveOnRope moveOnRope))
        {
            _playerJoint = player.gameObject.GetComponent<HingeJoint2D>();
            _playerJoint.connectedBody = _rigidBody;
            _playerJoint.enabled = true;
        }        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        print("отключаем");
        _collider.enabled = false;
    }
}
