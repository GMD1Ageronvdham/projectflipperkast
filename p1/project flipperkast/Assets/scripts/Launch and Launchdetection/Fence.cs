using UnityEngine;
using System.Collections;

public class Fence : MonoBehaviour {

	void Start () {
        gameObject.GetComponent<MeshCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
	void Update () {
	
        if (GameObject.Find("AfterFireDetect").GetComponent<BallFired>().playing == true)
        {
            gameObject.GetComponent<MeshCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        } else {
            gameObject.GetComponent<MeshCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
