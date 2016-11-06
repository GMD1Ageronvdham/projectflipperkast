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
            force = -60;
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 2)
        {
            force = -70;
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 3)
        {
            force = -80;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        direction = collision.contacts[0].point;
        ball.AddForce(direction * force);
    }
}