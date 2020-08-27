using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ball : MonoBehaviour
{
    Vector3 velocity;

    [Range(0, 1)]
    float speed = 0.2f;


    void Start()
    {
        ResetBall();
    }

    void ResetBall()
    {
        transform.position = Vector3.zero;
        float z = Random.Range(0, 2) * 2f - 1f;
        float x = Random.Range(0, 2) * 2f - 1f * Random.Range(0.2f, 1f);
        velocity = new Vector3(x, 0, z);
    }

    void FixedUpdate()
    {

        velocity = velocity.normalized * speed;
        transform.position += velocity;

    }
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.transform.name)
        {
            case "bounds East":
            case "bounds West":
                velocity.x *= -1f;
                return;
            case "Bounds North":
            case "Bounds South":
                ResetBall();
                return;
            case "Player Paddle":
            case "Computer Paddle":
                velocity.z *= -1f;
                return;




        }
    }


}
