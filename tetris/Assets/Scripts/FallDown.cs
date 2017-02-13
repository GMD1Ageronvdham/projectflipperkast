using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{ 
    public bool startfalling;
    public float speed;
    public float timer;
    public GamList listscript;
    void Start ()
    {
        startfalling = true;
	}
	
	void Update ()
    {
		if (startfalling == true)
        {
            timer = timer + Time.deltaTime;
            if (timer > speed && listscript.next == false)
            {
                timer = 0;
                transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
            }
        }
	}
}
