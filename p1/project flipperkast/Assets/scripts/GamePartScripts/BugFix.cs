using UnityEngine;
using System.Collections;
// dit is een script die een bugg fixt waarbij de ball blijft liggen op de office iconen
public class BugFix : MonoBehaviour {

	void Update ()
    {
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched > 0.5f)
        {
            GameObject.Find("bugfixone").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("bugfixtwo").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("bugfixthree").GetComponent<BoxCollider>().enabled = true;
            GameObject.Find("bugfixfour").GetComponent<BoxCollider>().enabled = true;
            // als je in een gamestadium zit, dan gaan de boxcolliders aan. dit is een driehoek boven de iconen, waardoor de ball er af rolt
        } else {
            GameObject.Find("bugfixone").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("bugfixtwo").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("bugfixthree").GetComponent<BoxCollider>().enabled = false;
            GameObject.Find("bugfixfour").GetComponent<BoxCollider>().enabled = false;
        }


    }
}
