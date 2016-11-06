using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour
{
    public Vector3 direction;
    public Rigidbody ball;
    public int force;

    void Update()
    {
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 0)
        {
            force = -50;
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 1)
        {
            force = -100;
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 2)
        {
            force = -150;
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 3)
        {
            force = -200;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        direction = collision.contacts[0].point;
        ball.AddForce(direction * force);
    }
}