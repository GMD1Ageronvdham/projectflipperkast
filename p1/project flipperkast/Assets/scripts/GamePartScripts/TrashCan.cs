using UnityEngine;
using System.Collections;
// dit script is een timer om aan te geven dat de flipper is aangeraakt.
// dit script word gebruikt voor de taakbalk, en heeft verder geen functie
public class TrashCan : MonoBehaviour {

    public bool touched;
    public float timer;

    void Update ()
    {
	    if (touched == true)
        {
            timer = timer + Time.deltaTime;
            // de timer
        }
        if (timer > 2)
        {
            touched = false;
            timer = 0;
            // als de timer groter is dan 2 word alles gereset
        }
	}
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
        // de timer word hiermee aangezet
    }
}
