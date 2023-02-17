using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectToRope : MonoBehaviour
{
    private BoxCollider2D ropeEndCollider;
    private DistanceJoint2D ohmaaanJoint;
    private Rigidbody2D ropeEndRigid;
    void Start()
    {
        ropeEndCollider = GetComponent<BoxCollider2D>();
        ropeEndRigid = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (ropeEndCollider != col && ropeEndCollider.isTrigger && col.gameObject.CompareTag("Player"))
        {
            Destroy(ropeEndCollider);
            ohmaaanJoint = col.gameObject.GetComponent<DistanceJoint2D>();
            ohmaaanJoint.connectedBody = ropeEndRigid;
            ohmaaanJoint.enabled = true;
        }
    }
}
