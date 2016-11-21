using UnityEngine;
using System.Collections;
// dit script word gebruikt door internet explorer aan te geven dat de ball het icoon heeft geraakt
// voor effect op de ball, zie het InternetBall script
public class InternetExplorer : MonoBehaviour {
    public bool slowness;
    public float timer;
	void Start () {
	
	}

	void Update () {
	    if (slowness == true)
        {
            timer = timer + Time.deltaTime;
            // de timer gaat lopen
        } else
        {
            timer = 0;
            // timer word gereset als slowness effect word uitgezet
        }
        if (timer > 30f)
        {
            slowness = false;
            // het effect duurt 30 seconden
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            slowness = false;
            // als je dood gaat, word het slowness effect ook uitgezet
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        slowness = true;
        // als de ball internet raakt, gaat de boolean aan
    }
}
