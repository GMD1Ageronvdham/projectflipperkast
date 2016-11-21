using UnityEngine;
using System.Collections;
// dit script detect de ball als hij onderin de machine ligt en je dus af bent
public class DeadDetect : MonoBehaviour {

    public float timer;
    public bool touch;

	void Update () {
        if (touch == true)
        {
            timer = timer + Time.deltaTime;
            // na 0,5 seconden word touch weer uitgeschakeld door deze boolean
        }
        if (GameObject.Find("Ball").GetComponent<Dead>().transport == true && timer > 0.5f )
        {
            touch = false;
            timer = 0;
            // transport is een conditie die word aangezet als de bal is geteleporteerd naar het startpunt
        }
	}
    public void OnCollisionEnter (Collision collision)
    {
        touch = true;
        GameObject.Find("Ball").GetComponent<Dead>().pinballs = GameObject.Find("Ball").GetComponent<Dead>().pinballs -1;
        // als de ball onderin ligt, word touch aangezet, wat de functies aanroept. ook word er een ball afgeschreven
    }
}
