using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steering : MonoBehaviour
{
    public WheelCollider FL;
    public WheelCollider FR;
    public WheelCollider BL;
    public WheelCollider BR;

    // Update is called once per frame
    void Update()
    {
        float steerAngle = 0f;
        float motor = 0f;
        float breakTorque = 0f;

        if (Input.GetKey(KeyCode.W))
            motor += 1000f;
        if (Input.GetKey(KeyCode.S))
            motor -= 1000f;
        if (Input.GetKey(KeyCode.Space))
            breakTorque += 100000f;
        if (Input.GetKey(KeyCode.D))
            steerAngle += 10f;
        if (Input.GetKey(KeyCode.A))
            steerAngle -= 10f;

        FL.steerAngle = steerAngle;
        FR.steerAngle = steerAngle;
        BL.motorTorque = motor;
        BR.motorTorque = motor;
        FL.brakeTorque = breakTorque;
        FR.brakeTorque = breakTorque;
        BL.brakeTorque = breakTorque;
        BR.brakeTorque = breakTorque;
    }
}
