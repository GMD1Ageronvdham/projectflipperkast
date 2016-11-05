using UnityEngine;
using System.Collections;

public class InternetExplorer : MonoBehaviour {
    public bool slowness;
    public float timer;
	void Start () {
	
	}

	void Update () {
	    if (slowness == true)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            timer = 0;
        }
        if (timer > 30f)
        {
            slowness = false;
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            slowness = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        slowness = true;
    }
}
