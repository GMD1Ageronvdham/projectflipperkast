using UnityEngine;
using System.Collections;

public class Shutdown : MonoBehaviour {

    public float timer;
    public float timertwo;
    public bool touched;
    public Vector3 move;
    public Rigidbody ball;

	void Update ()
    {
        if (touched == true)
        {
            ball.AddForce(move);
            timertwo = (timertwo + Time.deltaTime) * -1;
            timer = timer + Time.deltaTime;
            move.x = timertwo * 1000000;
            move.z = timertwo * 1000000;
        }
        if (timer > 3)
        {
            touched = false;
            timer = 0;
            timertwo = 0;
            move.x = 0;
            move.z = 0;
        }
        if (timertwo > 1 || timertwo < -1)
        {
            timertwo = 0;
        }
	}
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
        GameObject.Find("MyDocuments").GetComponent<Documents>().touched = 0;
    }
}
