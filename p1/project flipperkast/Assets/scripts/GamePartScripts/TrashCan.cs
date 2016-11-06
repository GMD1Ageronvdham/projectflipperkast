using UnityEngine;
using System.Collections;

public class TrashCan : MonoBehaviour {

    public bool touched;
    public float timer;

    void Update ()
    {
	    if (touched == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (timer > 2)
        {
            touched = false;
            timer = 0;
        }
	}
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
    }
}
