using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody Ball;
    [SerializeField]
    Vector3 BallVelocityX;
    [SerializeField]
    Vector3 BallVelocityZ;
    [SerializeField]
    KeyCode MoveRight;
    [SerializeField]
    KeyCode MoveLeft;
    [SerializeField]
    KeyCode MoveUp;
    [SerializeField]
    KeyCode MoveDown;
    // Start is called before the first frame update
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveRight))
        {
            Ball.velocity += BallVelocityX;
        }
        else if (Input.GetKey(MoveLeft))
        {
            Ball.velocity -= BallVelocityX;
        }
        else if (Input.GetKey(MoveUp))
        {
            Ball.velocity += BallVelocityZ;
        }
        else if (Input.GetKey(MoveDown))
        {
            Ball.velocity -= BallVelocityZ;
        }
    }
}
