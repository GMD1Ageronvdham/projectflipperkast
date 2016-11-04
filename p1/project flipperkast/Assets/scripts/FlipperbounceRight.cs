using UnityEngine;
using System.Collections;

public class FlipperbounceRight : MonoBehaviour
{
    public bool flipperactivatedleft;
    public bool flipperactivatedright;
    public float counterleft;
    public float counterright;
    public int handen = 1;
    public Rigidbody speler;
    public Vector3 force;
    public bool hit;
    public bool timershot;
    // Update is called once per frame
    void Update()
    {
        //The input of the button starts a timer that resets after a short period of time hopefully the time it takes for the flipper to reach its rotation

        if (Input.GetKey(KeyCode.RightShift))
        {
            timershot = true;
            flipperactivatedright = true;
        }
        else
        {
            timershot = false;
            counterright = 0;
            flipperactivatedright = false;
            handen = 0;
        }
        if (counterright >= 0.06f)
        {
            timershot = false;
            counterright = 0;
            handen = 0;
            hit = false;
        }
        if (timershot == true)
        {
            Tim();
        }
        else
            handen = 0;
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            speler.AddForce(force * counterright);
            hit = true;
        }
        else hit = false;
    }
    public void Tim()
    {
        handen = handen + 1;
        counterright = handen * Time.deltaTime;
    }
}
