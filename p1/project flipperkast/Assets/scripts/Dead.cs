using UnityEngine;
using System.Collections;

public class Dead : MonoBehaviour {

    public Vector3 Endposition;
    public bool transport;
	void Start () {
	
	}

	void Update () {

        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            transform.position = Endposition;
            transport = true;
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == false && transport == true)
        {
            transport = false;
        }
            
    }
}
