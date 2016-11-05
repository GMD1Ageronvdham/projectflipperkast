using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timelaunchpower : MonoBehaviour
{
    public float counter;
    public int launchspeed;
    public Vector3 force;
    public Rigidbody ball;
    public bool readytolaunch;
    public Text tekst;
    public bool count;

    // Update is called once per frame
    void Update()
    {
        if (readytolaunch == true &&
            Input.GetButtonUp("Jump"))
        {
            ball.AddForce(force * counter);
        }
        if (Input.GetButtonUp("Jump"))
        {
            readytolaunch = false;
            count = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            count = true;
        }
        if (count == true && counter < 3)
        {
            Timer();
        } else {
            count = false;
        }
        if (counter > 3)
        {
            counter = 0;
        }
        if (counter < 0.5f)
        {
            launchspeed = 1;
        } else if (counter > 0.1f && counter < 1f)
        {
            launchspeed = 2;
        } else if (counter < 1.5f)
        {
            launchspeed = 3;
        } else if (counter < 2f)
        {
            launchspeed = 4;
        } else if (counter < 2.5f)
        {
            launchspeed = 5;
        } else if (counter < 3f)
        {
            launchspeed = 6;
        }
        tekst.text = launchspeed.ToString();
    }
    public void Timer()
    {
        if (readytolaunch == true)
        {
            counter = counter + Time.deltaTime;
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