using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// dit script lanceert de bal
// dit script is een samenwerkingsproject tussen mij, Geron, en Steven
public class Timelaunchpower : MonoBehaviour
{
    public float counter;
    public int launchspeed;
    public Vector3 force;
    public Rigidbody ball;
    public bool readytolaunch;
    public Text tekst;
    public bool count;

    void Update()
    {
        if (readytolaunch == true && Input.GetButtonUp("Jump"))
        {
            ball.AddForce(force * counter);
            // deze if statement voegt de force toe. dit kan alleen als de bal op het launch platform ligt en de knop is ingedrukt
        }
        if (Input.GetButtonUp("Jump"))
        {
            readytolaunch = false;
            count = false;
            // als de knop word losgelaten, word de counter uitgezet
        }
        if (Input.GetButtonDown("Jump"))
        {
            count = true;
        }
        if (count == true && counter < 3)
        {
            Timer();
            // deze if statement roept de timer aan
        } else {
            count = false;
        }
        if (counter > 3)
        {
            counter = 0;
            // als de counter boven de 3f komt, word hij gereset naar 0 en begin je opnieuw te tellen
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
        // de if statements hierboven zijn voor het weergeven van de launchspeed op het scherm. hieronder word deze geoutput naar het beeld
        tekst.text = launchspeed.ToString();
    }
    public void Timer()
    {
        if (readytolaunch == true)
        {
            counter = counter + Time.deltaTime;
            // de timer
        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "launcher")
        {
            readytolaunch = true;
            // er mag pas getelt worden vanaf het moment dat de bal het launchplatform raakt
        }
    }
}