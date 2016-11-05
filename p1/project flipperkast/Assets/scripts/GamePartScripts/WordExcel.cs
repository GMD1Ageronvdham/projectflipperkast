using UnityEngine;
using System.Collections;

public class WordExcel : MonoBehaviour {

    public bool touched;

	void Update () {
	
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 1)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 0)
        {
            touched = false;
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
    }
}
