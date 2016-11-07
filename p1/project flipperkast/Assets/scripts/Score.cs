using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// in dit script worden alles scores bij elkaar opgeteld
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
        // alle floats worden overgenomen naar floats in dit script, dit was handiger voor testen, maar ook om de berekening hieronder overzichtelijker te maken
        score = scoreword + scoreexcel + scorepowerpoint + scoreoutlook + scorepublisher + scoreacces 
        + scoreinternet + scoreprullebak +scoredocuments + scoreLB + scoreRB; 
        // de uiteindelijke berekening
        if (score < 0)
        {
            score = 0;
            // als de score door de trashcan onder de 0 komt, word deze terug naar 0 gezet.
        }
        if (GameObject.Find("Canvas").GetComponent<Af>().readscore == true)
        {
            score = 0;
            scoreword = 0;
            scoreexcel = 0;
            scoreoutlook = 0;
            scorepowerpoint = 0;
            scoreacces = 0;
            scorepublisher = 0;
            scoreinternet = 0;
            scoreprullebak = 0;
            scoredocuments = 0;
            scoreLB = 0;
            scoreRB = 0;
            GameObject.Find("Word").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Excel").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Outlook").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Powerpoint").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Acces").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Publisher").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Internet").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("prullebak").GetComponent<ScoreAdd>().scoretaken= 0;
            GameObject.Find("MyDocuments").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("ColliderL").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("ColliderR").GetComponent<ScoreAdd>().scoretaken = 0;
            GameObject.Find("Canvas").GetComponent<Af>().readscore = false;
            // readscore is een boolean gemaakt om de score te resseten, nadat deze is geoutput in het startmenu
        }
        tekst.text = score.ToString();
    }
}
