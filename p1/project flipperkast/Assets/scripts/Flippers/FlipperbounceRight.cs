using UnityEngine;
using System.Collections;
// dit is het script voor de bounce ball op de rechterflipper
// dit script is een samenwerkingsproject tussen mij, Geron, en Steven
public class FlipperbounceRight : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightShift))
        {
            timershot = true;
            flipperactivatedright = true;
            // de input start een aantal boolean om een timer aan te zetten
        } else {
            timershot = false;
            counterright = 0;
            flipperactivatedright = false;
            var = 0;
            // alles word gedissabled en uitgezet als de knop niet is ingedrukt(in de praktijk zijn hier wat onfixbare problemen mee)
        }
        if (counterright >= 0.06f)
        {
            timershot = false;
            counterright = 0;
            var = 0;
            hit = false;
            // als de flipper de beweging gehad heeft en weer stilstaat word ook alles uitgezet (werkt in de praktijk ook niet perfect)
        }
        if (timershot == true)
        {
            Timer();
            // hier word de fuctie aangeroepen die de timer bijhoud
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
            // hier word de force toegevoegd als de ball de flipper raakt
        } else {
            hit = false;
        }
    }
    public void Timer()
    {
        var = var + 1;
        counterright = var * Time.deltaTime;
        // dit is de timer
    }
}
