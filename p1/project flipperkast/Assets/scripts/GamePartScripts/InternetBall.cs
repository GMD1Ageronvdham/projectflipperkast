using UnityEngine;
using System.Collections;

public class InternetBall : MonoBehaviour {

    public Vector3 physicsslow;
    public Vector3 physicsnormal;
    public bool low;
	
	void Update () {

        if (GameObject.Find("Internet").GetComponent<InternetExplorer>().slowness == true )
        {
            Physics.gravity = physicsslow;
            low = true;
        } else {
            Physics.gravity = physicsnormal;
            low = false;
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            Physics.gravity = physicsnormal;
            low = false;
        }
    }
}
