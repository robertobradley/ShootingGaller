using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningTargetController : MonoBehaviour {

    public float torque;

    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(0, 0, torque);
    }

    void FixedUpdate()
    {
        
    }
}
