using UnityEngine;
using System.Collections;
// dit script zorgt ervoor dat de fence aanstaat als de ball zich in het speelveld bevind of als het menu aan staat
public class Fence : MonoBehaviour {


	void Update () {
        if (GameObject.Find("Canvas").GetComponent<GameStart>().gamestart == false)
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            // als het menu aan staat, gaat de fence ook aan
        } else if (GameObject.Find("AfterFireDetect").GetComponent<BallFired>().playing == true)
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            // als de ball over de fence heen is, word deze aangezet. dit gebeurt met een collisiondetection door middel van oncollisionexit in het script Ballfired
        } else {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    
}
