using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// dit script word in werking gesteld als je pinballs op zijn en je dus af bent
public class Af : MonoBehaviour {

    public Text lastscoretext;
    public Text Highscoretext;
    public float timer;
    public float lastscore;
    public float highscore;
    public bool startcounting;
    public bool readscore;
    public string highscorestring;
	void Start ()
    {
        GameObject.Find("Af").GetComponent<RawImage>().enabled = false;
        // het af scherm word uitgezet aan de start van het spel
	}
	
	void Update ()
    {
        if(GameObject.Find("Ball").GetComponent<Dead>().pinballs == 0)
        {
            startcounting = true;
            GameObject.Find("Ball").GetComponent<Dead>().pinballs = 3;
            // het aantal pinballs word terug op 3 gezet en met startcounting gaat het af zijn in werking
        }
        if (startcounting == true)
        {
            timer = timer + Time.deltaTime;
            // de timer
        }
        if (timer > 0.1 && timer < 5)
        {
            GameObject.Find("Af").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("Af").GetComponent<RawImage>().enabled = false;
            // als de timer aan het tellen is en kleiner is dan 5 dan word het af scherm weergegeven
        }
        if (timer > 5)
        {
            startcounting = false;
            timer = 0;
            // na 5 seconden word de timer uitgezet
            GameObject.Find("Canvas").GetComponent<GameStart>().gamestart = false;
            // hiermee word het standaartmenu weer ge opent
            lastscoretext.text = GameObject.Find("Score").GetComponent<Text>().text;
            lastscore = GameObject.Find("GameParts").GetComponent<Score>().score;
            // de score worden ge output naar het startscherm
            readscore = true;
            // de score is gelezen, dus word nu teruggezet naar 0 in het score script
            if (lastscore > highscore)
            {
                highscore = lastscore;
                // als de score hoger is dan de highscore, word deze vervangen
            }
            Highscoretext.text = highscore.ToString();
            // de highscore word geprint
        }
	}
}
