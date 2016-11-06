using UnityEngine;
using System.Collections;
// dit script zet de Word en Excel iconen aan als je in het eerste stadium van de game zit
// ook houd dit script bij of de objecten zijn aangeraakt, wat nodig is voor de volgende stadia
public class WordExcel : MonoBehaviour {

    public bool touched;

	void Update () {
	
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 1)
        {
            gameObject.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            // touched == 1 betekend dat je in het eerste stadium zit van de game. hierin spelen word en excel mee
        } else {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            // als MyDocument nog niet is geactiveerd of je zit in een hoger stadium, dan worden Word en Excel  niet weergegeven
        }
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched == 0)
        {
            touched = false;
            // dit reset de touched knop als MyDocuments gedeactiveerd word, dit gebeurt als de shutdownbutton word aangeraakt( al teleporteerd deze vaak de bal tegen MyDocuments aan, en word het weer aangezet) of als je een nieuwe bal hebt gekregen
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = true;
        // als word of excel is aangeraakt gaat touched naar aan
    }
}
