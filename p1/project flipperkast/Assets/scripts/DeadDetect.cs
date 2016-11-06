using UnityEngine;
using System.Collections;

public class DeadDetect : MonoBehaviour {

    public float timer;
    public bool touch;

	void Update () {
        if (touch == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (GameObject.Find("Ball").GetComponent<Dead>().transport == true && timer > 0.5f )
        {
            touch = false;
            timer = 0;
        }
	}
    public void OnCollisionEnter (Collision collision)
    {
        touch = true;
        GameObject.Find("Ball").GetComponent<Dead>().pinballs = GameObject.Find("Ball").GetComponent<Dead>().pinballs -1;
    }
}
