using UnityEngine;
using System.Collections;

public class BugFix : MonoBehaviour {

	void Update ()
    {
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched > 0.5f)
        {
            GameObject.Find("bugfixone").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("bugfixtwo").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("bugfixthree").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("bugfixfour").GetComponent<BoxCollider>().enabled = true;
        } else {
            GameObject.Find("bugfixone").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("bugfixtwo").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("bugfixthree").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("bugfixfour").GetComponent<BoxCollider>().enabled = false;
        }


    }
}
