using UnityEngine;
using System.Collections;

public class Fence : MonoBehaviour {


	void Update () {
        if (GameObject.Find("Canvas").GetComponent<GameStart>().gamestart == false)
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        } else if (GameObject.Find("AfterFireDetect").GetComponent<BallFired>().playing == true)
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        } else {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
    
}
