using UnityEngine;
using System.Collections;

public class Documents : MonoBehaviour {

    public int touched;
	void Start () {
	
	}
	
	void Update () {

        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            touched = 0;
        }
        if (touched == 2 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true)
        {
            touched = 2;
        } else if (touched == 3 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Outlook").GetComponent<OutlookPowerpoint>().touched == true &&
            GameObject.Find("Powerpoint").GetComponent<OutlookPowerpoint>().touched == true)
        {
            touched = 3;
        } else if (touched > 1) {
            touched = touched - 1;
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = touched + 1;
    }
    
}
