using UnityEngine;
using System.Collections;

public class FlipperMoveRight : MonoBehaviour
{
    public bool flipactivated;
    public bool activeFlipper;
    public bool deactiveFlipper;
    public bool buttonhold;
    public bool endoftheline;
    public bool flipperactive;
    public float timer1 = 0;
    public float timer2 = 0;
    public float speed;
    public GameObject flipperLinks;
    public Vector3 endplace;
    public Vector3 startplace;
    public Vector3 direction;
    public Rigidbody ball;
    public int force;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift) && flipactivated == false)
        {
            activeFlipper = true;
            buttonhold = true;
            flipactivated = true;
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            buttonhold = false;
        }
        if (timer1 > 12f)
        {
            activeFlipper = false;
            endoftheline = true;
            timer1 = 0;
            transform.localEulerAngles = endplace;
        }
        if (buttonhold == false && endoftheline == true)
        {
            deactiveFlipper = true;
        }

        if (timer2 > 12f)
        {
            deactiveFlipper = false;
            timer2 = 0;
            flipactivated = false;
            transform.localEulerAngles = startplace;
        }
        if (activeFlipper == true)
        {
            transform.RotateAround
                (transform.position,
                flipperLinks.transform.forward,
                400 * Time.deltaTime);

            timer1 = timer1 + (Time.deltaTime * 100);
        }
        if (deactiveFlipper == true)
        {
            transform.RotateAround
               (transform.position,
               flipperLinks.transform.forward,
               -400 * Time.deltaTime);
            timer2 = timer2 + (Time.deltaTime * 100);
            endoftheline = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (activeFlipper == true)
        {
            direction = collision.contacts[0].point;
            ball.AddForce(direction * force);
        }
    }
}
