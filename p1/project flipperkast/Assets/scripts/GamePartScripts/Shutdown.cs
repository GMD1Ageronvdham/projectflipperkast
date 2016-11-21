using UnityEngine;
using System.Collections;
// dit script word gebruikt door de shutdown knop bovenin de flipperkast
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
            // de force word hier toegevoegd. ook worden de timers gestart. door de * -1 bij timer2 word deze continue wisseld tussen een positief en negatief getal
        }
        if (timer > 3)
        {
            touched = false;
            timer = 0;
            timertwo = 0;
            move.x = 0;
            move.z = 0;
            // na 3 seconden word de shutdown functie gedissabled
        }
        if (timertwo > 1 || timertwo < -1)
        {
            timertwo = 0;
            // als de 2e timer(welke word gebruikt om de force van de ball random te maken) boven 1 of onder de -1 komt, word deze gereset naar 0
        }
	}
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
        GameObject.Find("MyDocuments").GetComponent<Documents>().touched = 0;
        // als de shutdown is aangeraakt, word touched op true gezet, wat verdere handelingen aanstuurt. ook word MyDocuments gereset( vaak teleporteerd de ball echter tegen mydocuments aan, waardoor deze terug op stadium 1 komt)
    }
}
