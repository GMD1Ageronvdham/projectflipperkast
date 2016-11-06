using UnityEngine;
using System.Collections;

public class OutlookPowerpoint : MonoBehaviour {

    public bool touched;

    void Update()
    {
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 2 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        } else {
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
