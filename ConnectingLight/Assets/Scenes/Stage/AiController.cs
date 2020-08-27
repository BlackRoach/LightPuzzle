using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{

    public Transform ball;
    
    [Range(0, 1)]
    public float skill;
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.x = Mathf.Lerp(transform.position.x, ball.position.x, skill);
        transform.position = newPos;
    }
}
