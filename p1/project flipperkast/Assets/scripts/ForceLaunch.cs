using UnityEngine;
using System.Collections;

public class ForceLaunch : MonoBehaviour
{
    public Rigidbody speler;
    public Vector3 force;
    public bool readytolaunch;

    // Update is called once per frame
    void Update()
    {

        if (readytolaunch == true
            &&
            Input.GetButton("Jump"))
        {
            speler.AddForce(force);

        }
        if (Input.GetButton("Jump"))
        {
            readytolaunch = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "launcher")
        {
            readytolaunch = true;

        }
    }

}