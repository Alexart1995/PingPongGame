using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobe : MonoBehaviour
{
    private float speed = 5f;
    //Rigidbody2D P1RigidBody;
    // Start is called before the first frame update
    //void Start()
    //{
    //    P1RigidBody = GetComponent<Rigidbody2D>();
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    float VertMove = Input.GetAxis("Vertical");
    //    Vector2 move = new Vector2(0f, VertMove);
    //    P1RigidBody.AddForce(move * speed);
    //}

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed; 
    }
}
