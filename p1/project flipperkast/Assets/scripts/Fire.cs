using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{
    public Vector3 direction;
    public Rigidbody ball;

    public void OnCollisionEnter(Collision collision)
    {
       ball.AddForce(direction);
    }
}
