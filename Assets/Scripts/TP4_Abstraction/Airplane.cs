using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : Vehicle
{
    protected override void Accelerationn()
    {
        Debug.Log("Input !0");
        Speed += Acceleration * MoveInput * Time.deltaTime;

    }

    protected override void Decelleration()
    {
        Debug.Log("Input 0");
        Speed -= BrakeForce * Mathf.Abs(MoveInput) * Time.deltaTime;
        Speed -= BrakeForce * Time.deltaTime;
    }

    protected override void Turn()
    {
        transform.Rotate(0, TurnInput * Handling * Speed * Time.deltaTime, 0);
    }
}
