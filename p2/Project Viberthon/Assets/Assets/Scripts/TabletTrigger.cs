using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletTrigger : MonoBehaviour
{

    public bool hit;
    public GameObject manager;
	

	void Update ()
    {
		
	}
    void OnTriggerEnter(Collider other)
    {
        hit = true;
        manager.GetComponent<Manager>().runloop = true;
    }
}
