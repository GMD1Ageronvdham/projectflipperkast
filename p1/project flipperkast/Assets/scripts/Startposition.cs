using UnityEngine;
using System.Collections;

public class Startposition : MonoBehaviour {

    public Vector3 startposition;
    public bool reset;

	void Update () {

        if (GameObject.Find("balk").GetComponent<ResetBall>().balreset == true)
            transform.position = startposition;
            reset = true;
        if (GameObject.Find("balk").GetComponent<ResetBall>().balreset == false)
            reset = false;

	}
}
