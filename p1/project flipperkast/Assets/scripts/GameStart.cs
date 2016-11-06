using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameStart : MonoBehaviour {

    public bool gamestart;
    public Button start;

	void Update ()
    {
        if (gamestart == true)
        {
            GameObject.Find("MenuBackground").GetComponent<RawImage>().enabled = false;
            GameObject.Find("HighScore").GetComponent<RawImage>().enabled = false;
            GameObject.Find("LastScore").GetComponent<RawImage>().enabled = false;
            GameObject.Find("StartMenu").GetComponent<RawImage>().enabled = false;
            GameObject.Find("Uitleg").GetComponent<RawImage>().enabled = false;
            GameObject.Find("Logo").GetComponent<RawImage>().enabled = false;
            GameObject.Find("StartButton").GetComponent<Image>().enabled = false;
            GameObject.Find("StartButton").GetComponent<Button>().enabled = false;
            GameObject.Find("StartText").GetComponent<Text>().enabled = false;
        } else {
            GameObject.Find("MenuBackground").GetComponent<RawImage>().enabled = true;
            GameObject.Find("HighScore").GetComponent<RawImage>().enabled = true;
            GameObject.Find("LastScore").GetComponent<RawImage>().enabled = true;
            GameObject.Find("StartMenu").GetComponent<RawImage>().enabled = true;
            GameObject.Find("Uitleg").GetComponent<RawImage>().enabled = true;
            GameObject.Find("Logo").GetComponent<RawImage>().enabled = true;
            GameObject.Find("StartButton").GetComponent<Image>().enabled = true;
            GameObject.Find("StartButton").GetComponent<Button>().enabled = true;
            GameObject.Find("StartText").GetComponent<Text>().enabled = true;
        }
	}
    public void buttonClicked()
    {
        gamestart = true;
    }
}
