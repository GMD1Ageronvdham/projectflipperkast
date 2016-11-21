using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// vanwege het feit dat het handig is om de game op pauze te kunnen zetten tijdens het spelen of terug naar het menu te gaan
// heb ik dit script op het laatste moment nog gemaakt 
public class StopPauze : MonoBehaviour {

    public Button pauze;
    public Button play;
    public Button stop;

    void Start()
    {
        GameObject.Find("play").GetComponent<Image>().enabled = false;
        GameObject.Find("play").GetComponent<Button>().enabled = false;
        GameObject.Find("Playtext").GetComponent<Text>().enabled = false;
        // de playbutton word uitgezet
    }
    public void pauzebuttonClicked()
    {
        GameObject.Find("Ball").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        GameObject.Find("Pauze").GetComponent<Image>().enabled = false;
        GameObject.Find("Pauze").GetComponent<Button>().enabled = false;
        GameObject.Find("Pauzetext").GetComponent<Text>().enabled = false;
        GameObject.Find("play").GetComponent<Image>().enabled = true;
        GameObject.Find("play").GetComponent<Button>().enabled = true;
        GameObject.Find("Playtext").GetComponent<Text>().enabled = true;
        // als de pauzeknop is ingedrukt word de pauzeknop uitgezet en de play knop aan de rigidbody word bevroren

    }
    public void stopbuttonClicked()
    {
        GameObject.Find("Ball").GetComponent<Dead>().pinballs = 0;
        // het aantal pinball word naar 0 gezet. dit brengt je in het startmenu
    }
    public void playbuttonclicked()
    {
        GameObject.Find("Ball").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        GameObject.Find("Pauze").GetComponent<Image>().enabled = true;
        GameObject.Find("Pauze").GetComponent<Button>().enabled = true;
        GameObject.Find("Pauzetext").GetComponent<Text>().enabled = true;
        GameObject.Find("play").GetComponent<Image>().enabled = false;
        GameObject.Find("play").GetComponent<Button>().enabled = false;
        GameObject.Find("Playtext").GetComponent<Text>().enabled = false;
        // de rigidbody gaat weer werken, de play knop word uitgezet en de pauzeknop weer aan

    }

}
