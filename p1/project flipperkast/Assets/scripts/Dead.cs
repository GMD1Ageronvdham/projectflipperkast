using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// dit script teleporteerd de ball als je af bent en trackt het aantal pinballs
public class Dead : MonoBehaviour {

    public int pinballs;
    public Vector3 Endposition;
    public bool transport;
    public Text tekst;

    void Start ()
    {
        pinballs = 3;
        // het aantal pinballs word naar 3 gezet aan de start van het spel
	}

	void Update ()
    {
        tekst.text = pinballs.ToString();
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().balladd == true)
        {
            pinballs = pinballs + 1;
            GameObject.Find("MyDocuments").GetComponent<Documents>().balladd = false;
            // deze conditie kijkt of je een ball mag toevoegen omdat het 4e stadium is bereikt van de office iconen
            // daarna word balladd uitgezet en moet je opnieuw beginnen voor de extra ball
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            transform.position = Endposition;
            transport = true;
            //hier word de ball getransporteerd
        }
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == false && transport == true)
        {
            transport = false;
            // als de ball getransporteerd is, word de conditie weer naar false gezet
        }
            
    }
}
