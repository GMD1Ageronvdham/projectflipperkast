using UnityEngine;
using System.Collections;
// dit script verandert de physics van de ball als internet is geraakt
public class InternetBall : MonoBehaviour {

    public Vector3 physicsslow;
    public Vector3 physicsnormal;
    public bool low;
	
	void Update () {

        if (GameObject.Find("Internet").GetComponent<InternetExplorer>().slowness == true )
        {
            Physics.gravity = physicsslow;
            low = true;
            // als internet is geraakt word de vector physicsslow geactiveerd
        } else {
            Physics.gravity = physicsnormal;
            low = false;
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            Physics.gravity = physicsnormal;
            low = false;
            // als je dood bent, word de traagheid uitgezet
        }
    }
}
