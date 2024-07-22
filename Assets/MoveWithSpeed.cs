using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithSpeed : MonoBehaviour
{
    public float upSpeed;
    public float downSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(Vector3.up, upSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(Vector3.down, downSpeed);
        }
    }

    void Move(Vector3 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
