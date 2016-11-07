using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// dit script zorgt ervoor dat de menu's goed worden weergegeven als de game start
public class GameStart : MonoBehaviour {

    public bool gamestart;
    public Button start;

	void Update ()
    {
        if (gamestart == true)
        {
            GameObject.Find("HighScore").GetComponent<RawImage>().enabled = false;
            GameObject.Find("LastScore").GetComponent<RawImage>().enabled = false;
            GameObject.Find("StartMenu").GetComponent<RawImage>().enabled = false;
            GameObject.Find("Uitleg").GetComponent<RawImage>().enabled = false;
            GameObject.Find("Logo").GetComponent<RawImage>().enabled = false;
            GameObject.Find("StartButton").GetComponent<Image>().enabled = false;
            GameObject.Find("StartButton").GetComponent<Button>().enabled = false;
            GameObject.Find("StartText").GetComponent<Text>().enabled = false;
            GameObject.Find("LastScoreText").GetComponent<Text>().enabled = false;
            GameObject.Find("HighscoreText").GetComponent<Text>().enabled = false;
            // het startmenu word uitgeschakeld
            GameObject.Find("Panel").GetComponent<Image>().enabled = true;
            GameObject.Find("Scoretekst").GetComponent<Text>().enabled = true;
            GameObject.Find("Score").GetComponent<Text>().enabled = true;
            GameObject.Find("Pinballstekst").GetComponent<Text>().enabled = true;
            GameObject.Find("Pinballs").GetComponent<Text>().enabled = true;
            GameObject.Find("Launchspeedtekst").GetComponent<Text>().enabled = true;
            GameObject.Find("Launchspeed").GetComponent<Text>().enabled = true;
            // het ingame menu word ingeschakeld

        } else {
            GameObject.Find("HighScore").GetComponent<RawImage>().enabled = true;
            GameObject.Find("LastScore").GetComponent<RawImage>().enabled = true;
            GameObject.Find("StartMenu").GetComponent<RawImage>().enabled = true;
            GameObject.Find("Uitleg").GetComponent<RawImage>().enabled = true;
            GameObject.Find("Logo").GetComponent<RawImage>().enabled = true;
            GameObject.Find("StartButton").GetComponent<Image>().enabled = true;
            GameObject.Find("StartButton").GetComponent<Button>().enabled = true;
            GameObject.Find("StartText").GetComponent<Text>().enabled = true;
            GameObject.Find("LastScoreText").GetComponent<Text>().enabled = true;
            GameObject.Find("HighscoreText").GetComponent<Text>().enabled = true;
            //het startmenu word aangezet
            GameObject.Find("Panel").GetComponent<Image>().enabled = false;
            GameObject.Find("Scoretekst").GetComponent<Text>().enabled = false;
            GameObject.Find("Score").GetComponent<Text>().enabled = false;
            GameObject.Find("Pinballstekst").GetComponent<Text>().enabled = false;
            GameObject.Find("Pinballs").GetComponent<Text>().enabled = false;
            GameObject.Find("Launchspeedtekst").GetComponent<Text>().enabled = false; 
            GameObject.Find("Launchspeed").GetComponent<Text>().enabled = false;
            // het ingamemenu uitgezet
        }
	}
    public void buttonClicked()
    {
        gamestart = true;
        // gamestart word aangezet als op de button is geklickd. word uitgezet vanuit een ander script
    }
}
