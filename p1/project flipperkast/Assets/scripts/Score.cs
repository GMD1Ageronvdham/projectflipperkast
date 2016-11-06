using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public float score;
    public float scoreword;
    public float scoreexcel;
    public float scoreoutlook;
    public float scorepowerpoint;
    public float scoreacces;
    public float scorepublisher;
    public float scoreinternet;
    public float scoreprullebak;
    public float scoredocuments;
    public float scoreLB;
    public float scoreRB;
    public Text tekst;
	void Start () {
	
	}
	
	void Update ()
    {
        scoreword = GameObject.Find("Word").GetComponent<ScoreAdd>().scoretaken;
        scoreexcel = GameObject.Find("Excel").GetComponent<ScoreAdd>().scoretaken;
        scoreoutlook = GameObject.Find("Outlook").GetComponent<ScoreAdd>().scoretaken;
        scorepowerpoint = GameObject.Find("Powerpoint").GetComponent<ScoreAdd>().scoretaken;
        scoreacces = GameObject.Find("Acces").GetComponent<ScoreAdd>().scoretaken;
        scorepublisher = GameObject.Find("Publisher").GetComponent<ScoreAdd>().scoretaken;
        scoreinternet = GameObject.Find("Internet").GetComponent<ScoreAdd>().scoretaken;
        scoreprullebak = GameObject.Find("prullebak").GetComponent<ScoreAdd>().scoretaken;
        scoredocuments = GameObject.Find("MyDocuments").GetComponent<ScoreAdd>().scoretaken;
        scoreLB = GameObject.Find("ColliderL").GetComponent<ScoreAdd>().scoretaken;
        scoreRB = GameObject.Find("ColliderR").GetComponent<ScoreAdd>().scoretaken;

        score = scoreword + scoreexcel + scorepowerpoint + scoreoutlook + scorepublisher + scoreacces 
        + scoreinternet + scoreprullebak +scoredocuments + scoreLB + scoreRB; 
        if (score < 0)
        {
            score = 0;
        }
        tekst.text = score.ToString();
    }
}
