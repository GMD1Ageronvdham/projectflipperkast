using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatingEnabled : MonoBehaviour
{
    public Text cheatingEnabled;
    public string Cheatcode1;
    public GameObject cheating;
	void Start ()
    {
        cheatingEnabled.enabled = false;
        cheating.SetActive(false);
	}
	
	void Update ()
    {
		
	}
    public void CheckForCheats(string text)
    {
        if (text == Cheatcode1)
        {
            cheatingEnabled.enabled = true;
            cheating.SetActive(true);
        }
    }
}
