using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
	}
	
	void Update ()
    {
        if(GameObject.Find("Ball").GetComponent<Dead>().pinballs == 0)
        {
            startcounting = true;
            GameObject.Find("Ball").GetComponent<Dead>().pinballs = 3;
        }
        if (startcounting == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (timer > 0.1 && timer < 5)
        {
            GameObject.Find("Af").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("Af").GetComponent<RawImage>().enabled = false;
        }
        if (timer > 5)
        {
            startcounting = false;
            timer = 0;
            GameObject.Find("Canvas").GetComponent<GameStart>().gamestart = false;
            lastscoretext.text = GameObject.Find("Score").GetComponent<Text>().text;
            lastscore = GameObject.Find("GameParts").GetComponent<Score>().score;
            readscore = true;
            if (lastscore > highscore)
            {
                highscore = lastscore;
            }
            PlayerPrefs.SetFloat(highscorestring, highscore);
            PlayerPrefs.Save();
            Highscoretext.text = highscore.ToString();
        }
	}
}
