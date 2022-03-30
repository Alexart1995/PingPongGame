using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public BallMove BallMove;
    public Score Score;
    public AudioSource music;

    void CollisionDetetection(Collision2D c)
    {
        Vector3     BallPos = this.transform.position;
        // our object which we use
        Vector3     RacketPos = c.gameObject.transform.position;
        // object with which we collide c
        float       RacketHeight = c.collider.bounds.size.y;
        float       x;
        float       y;

        if (c.gameObject.name == "Player1")
            x = -1;
        else
            x = 1;
        y = (BallPos.y - RacketPos.y) / RacketHeight;
        this.BallMove.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
            CollisionDetetection(collision);
        else if (collision.gameObject.name == "left")
        {
            this.gameObject.transform.localPosition = new Vector3(662, 1, -15);
            BallMove.MoveBall(new Vector2(1, 0));
            this.Score.Score2();

        }
        else if (collision.gameObject.name == "right")
        {
            this.gameObject.transform.localPosition = new Vector3(662, 1, -15);
            BallMove.MoveBall(new Vector2(-1, 0));
            this.Score.Score1();
        }
        else if (collision.gameObject.name == "top" || collision.gameObject.name == "down")
        {
            if (music)
                music.Play();
        }


    }

}
