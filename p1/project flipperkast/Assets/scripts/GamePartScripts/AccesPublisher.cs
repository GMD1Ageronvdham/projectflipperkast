using UnityEngine;
using System.Collections;
// dit script zet de publisher en acces iconen aan als je in het tweede stadium van de game zit
// ook houd dit script bij of de objecten zijn aangeraakt, wat nodig is voor de extra ball
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
            // dit zet de iconen aan als alle voorgaande stadia zijn voltooid en je naar stadium 3 gaat
        } else if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 4 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Outlook").GetComponent<OutlookPowerpoint>().touched == true &&
            GameObject.Find("Powerpoint").GetComponent<OutlookPowerpoint>().touched == true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            // voor het 4e deel word de ball toegevoed, kort hierna word het mydocuments stadium naar 0 gezet, waardoor alles weer reset word
        } else {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            touched = false;
            // in alle andere stadia moeten acces en publisher uit staan
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
        // als publisher of acces worden aangeraakt gaat touched aan
    }
}
