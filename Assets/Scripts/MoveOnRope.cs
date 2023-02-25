using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MoveOnRope : MonoBehaviour
{
    private Rigidbody2D _ohmaaanRigid;
    private HingeJoint2D _ohmaaanHinge;

    private void Start()
    {
        _ohmaaanRigid = GetComponent<Rigidbody2D>();
        _ohmaaanHinge = GetComponent<HingeJoint2D>();
    }

    private void Update()
    {
        float force = 0.03f;
        if (_ohmaaanHinge.enabled)
        {
            if (Input.GetKey(KeyCode.A))
            {
                _ohmaaanRigid.velocity += new Vector2(-force, 0);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _ohmaaanRigid.velocity += new Vector2(force, 0);
            }
        }
    }
}
