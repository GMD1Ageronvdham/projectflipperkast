using UnityEngine;
using System.Collections;

public class AccesPublisher : MonoBehaviour {

    public bool touched;

    void Update()
    {
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 3 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Outlook").GetComponent<OutlookPowerpoint>().touched == true &&
            GameObject.Find("Powerpoint").GetComponent<OutlookPowerpoint>().touched == true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            touched = false;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
    }
}
