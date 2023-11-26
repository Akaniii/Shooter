using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.left * 12;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
