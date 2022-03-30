using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Rigidbody2D Ball;
    public float speed = 5;
    //public float PlusSpeed;
    //public float MaxSpeed;

    int Hits;
    // Start is called before the first frame update
    void Start()
    {
        //Ball = GetComponent<Rigidbody2D>();
        MoveBall(new Vector2(1, 0));
    }

    public void MoveBall(Vector2 dir)
    {
        Rigidbody2D Ball;
        Ball = GetComponent<Rigidbody2D>();
        dir = dir.normalized;
        Ball.velocity = dir * speed;
        Ball.AddForce(Ball.velocity * speed);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
