using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wekkermanager : MonoBehaviour {

    public List<Wekker> wekkerlist = new List<Wekker>();
    public Wekker wekker;
	void Start () {
        wekker = new Wekker();
	}
	
	void Update () {
		if (Input.GetButtonDown("Jump"))
        {
            wekker.Test(5);
        }
	}
}
