using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {

    public bool startup;
	void Start ()
    {
        GameObject.Find("StartupSound").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("DocSound").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("ShutSound").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("TrashSound").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("InternetSound").GetComponent<AudioSource>().enabled = false;
    }

    void Update()
    {
        if (GameObject.Find("Canvas").GetComponent<GameStart>().gamestart == true)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.10f;
            startup = true;
        } else {
            GameObject.Find("Music").GetComponent<AudioSource>().volume = 0.35f;
            startup = false;
        }
        if (startup == true)
        {
            GameObject.Find("StartupSound").GetComponent<AudioSource>().enabled = true;
        }
        if (GameObject.Find("Word").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = true;
        } else if (GameObject.Find("Excel").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = true;
        } else if (GameObject.Find("Powerpoint").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = true;
        } else if (GameObject.Find("Outlook").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = true;
        } else if (GameObject.Find("Acces").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = true;
        } else if (GameObject.Find("Publisher").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = true;
        } else {
            GameObject.Find("OfficeSound").GetComponent<AudioSource>().enabled = false;
        }
        if (GameObject.Find("MyDocuments").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("DocSound").GetComponent<AudioSource>().enabled = true;
        } else {
            GameObject.Find("DocSound").GetComponent<AudioSource>().enabled = false;
        }
        if (GameObject.Find("prullebak").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("TrashSound").GetComponent<AudioSource>().enabled = true;
        } else {
            GameObject.Find("TrashSound").GetComponent<AudioSource>().enabled = false;
        }
        if (GameObject.Find("Internet").GetComponent<ScoreAdd>().touched == true)
        {
            GameObject.Find("InternetSound").GetComponent<AudioSource>().enabled = true;
        } else {
            GameObject.Find("InternetSound").GetComponent<AudioSource>().enabled = false;
        }
        if (GameObject.Find("Uitschakelen").GetComponent<Shutdown>().touched == true)
        {
            GameObject.Find("ShutSound").GetComponent<AudioSource>().enabled = true;
        } else {
            GameObject.Find("ShutSound").GetComponent<AudioSource>().enabled = false;
        }
    }
}
