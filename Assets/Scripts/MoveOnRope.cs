using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnRope : MonoBehaviour
{

    private Rigidbody2D ohmaaanRigid;

    void Start()
    {
        ohmaaanRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ohmaaanRigid.velocity += new Vector2(-0.01f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ohmaaanRigid.velocity += new Vector2(0.01f, 0.0f);
        }
    }
}
