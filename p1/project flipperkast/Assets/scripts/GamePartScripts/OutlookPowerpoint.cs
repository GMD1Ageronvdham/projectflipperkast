using UnityEngine;
using System.Collections;
// dit script zet de Outlook en Powerpoint iconen aan als je in het tweede stadium van de game zit
// ook houd dit script bij of de objecten zijn aangeraakt, wat nodig is voor de volgende stadia
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
            // als je in het tweede stadium zit en word en excel zijn aangeraakt, dan worden outlook en powerpoint zichtbaar
        } else {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            // als je in een eerder of later stadium zit gaan ze uit
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 0)
        {
            touched = false;
            // dit reset de touched knop als MyDocuments gedeactiveerd word, dit gebeurt als de shutdownbutton word aangeraakt(al teleporteerd deze vaak de bal tegen MyDocuments aan, en word het weer aangezet) of als je een nieuwe bal hebt gekregen
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
        // als outlook of powerpoint is aangeraakt, gaat touched aan
    }
}
