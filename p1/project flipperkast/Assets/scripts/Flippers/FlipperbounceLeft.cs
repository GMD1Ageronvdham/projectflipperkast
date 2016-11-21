using UnityEngine;
using System.Collections;
// dit is het script voor de bounce ball op de rechterflipper
// dit script is een samenwerkingsproject tussen mij, Geron, en Steven
// dit script is op de keycodes na, hetzelfde als het FlipperbounceRight script
// zie hierom het FlipperbounceRight script voor de uitleg
public class FlipperbounceLeft : MonoBehaviour
{
    public bool flipperactivatedleft;
    public bool flipperactivatedright;
    public float counterleft;
    public float counterright;
    public int var = 1;
    public Rigidbody speler;
    public Vector3 force;
    public bool hit;
    public bool timershot;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            timershot = true;
            flipperactivatedright = true;
        } else {
            timershot = false;
            counterright = 0;
            flipperactivatedright = false;
            var = 0;
        }
        if (counterright >= 0.06f)
        {
            timershot = false;
            counterright = 0;
            var = 0;
            hit = false;
        }
        if (timershot == true)
        {
            Timer();
        } else {
            var = 0;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ball")
        {
            speler.AddForce(force * counterright);
            hit = true;
        } else {
            hit = false;
        }
    }
    public void Timer()
    {
        var = var + 1;
        counterright = var * Time.deltaTime;
    }
}
