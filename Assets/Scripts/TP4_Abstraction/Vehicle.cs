using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public abstract class Vehicle : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Rigidbody rb;



    [Header("Variables")]
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float acceleration;
    [SerializeField] private float handling;
    [SerializeField] private float brakeForce;

    [Header("Input")]
    [SerializeField] private float moveInput;
    [SerializeField] private float turnInput;


    protected float Speed
    {
        get { return speed; }
        set { speed = Mathf.Clamp(value, 0, maxSpeed); }
    }
    protected float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    protected float Acceleration { get => acceleration; set => acceleration = value; }
    protected float Handling { get => handling; set => handling = value; }
    protected float BrakeForce { get => brakeForce; set => brakeForce = value; }
    public float MoveInput { get => moveInput; set => moveInput = value; }
    public float TurnInput { get => turnInput; set => turnInput = value; }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        MoveInput = Input.GetAxis("Vertical");
        TurnInput = Input.GetAxis("Horizontal");

        Turn();

        Debug.Log("Deplacement");
        if (MoveInput != 0)
        {
            Accelerationn();
        }
        if (MoveInput == 0)
        {
            Decelleration();
        }
        transform.Translate(default, default, speed * Time.deltaTime);

    }
    protected abstract void Accelerationn(); //abstraction
    protected abstract void Decelleration(); //abstraction
    protected abstract void Turn(); //abstraction
}
