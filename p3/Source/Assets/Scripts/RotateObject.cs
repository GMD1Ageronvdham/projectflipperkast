using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public enum Direction
    {
        Up,
        Forward,
        Left
    }

    public Direction direction;
    public float speed;
	void Update ()
    {
        if (direction == Direction.Up)
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        if (direction == Direction.Forward)
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        if (direction == Direction.Left)
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
