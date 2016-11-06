using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dead : MonoBehaviour {

    public int pinballs;
    public Vector3 Endposition;
    public bool transport;
    public Text tekst;

    void Start ()
    {
        pinballs = 3;
	}

	void Update ()
    {
        tekst.text = pinballs.ToString();
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().balladd == true)
        {
            pinballs = pinballs + 1;
            GameObject.Find("MyDocuments").GetComponent<Documents>().balladd = false;
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            transform.position = Endposition;
            transport = true;
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == false && transport == true)
        {
            transport = false;
        }
            
    }
}
