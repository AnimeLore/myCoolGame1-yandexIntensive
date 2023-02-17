using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisconnectFromRope : MonoBehaviour
{

    private DistanceJoint2D ohmaaanJoint;
    private Rigidbody2D ropeRigid;

    void Start()
    {
        ohmaaanJoint = GetComponent<DistanceJoint2D>();
        ropeRigid = ohmaaanJoint.connectedBody;
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           ohmaaanJoint.enabled = false;
        }
    }
}
