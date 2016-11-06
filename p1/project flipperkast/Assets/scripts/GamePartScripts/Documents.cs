using UnityEngine;
using System.Collections;
// hier worden alle stadia bijgehouden van de office programma's
public class Documents : MonoBehaviour {

    public int touched;
    public bool balladd;
	
	void Update () {

        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            touched = 0;
            // als je af bent gegaan word je progress gereset
        }
        if (touched == 2 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true)
        {
            touched = 2;
            // hier word er voor gezorgt dat touched op 2 blijft bij stadium 2
        } else if (touched == 3 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Outlook").GetComponent<OutlookPowerpoint>().touched == true &&
            GameObject.Find("Powerpoint").GetComponent<OutlookPowerpoint>().touched == true)
        {
            touched = 3;
            // hier word er voor gezorgt dat touched op 3 blijft bij stadium 3
        } else if (touched == 4 &&
            GameObject.Find("Word").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Excel").GetComponent<WordExcel>().touched == true &&
            GameObject.Find("Outlook").GetComponent<OutlookPowerpoint>().touched == true &&
            GameObject.Find("Powerpoint").GetComponent<OutlookPowerpoint>().touched == true &&
            GameObject.Find("Acces").GetComponent<AccesPublisher>().touched == true &&
            GameObject.Find("Publisher").GetComponent<AccesPublisher>().touched == true)
        {
            balladd = true;
            touched = 0;
            // balladd word gebruikt door een ander script en vanuit daar uitgezet
            // nadat de balladd is aangezet word je weer teruggezet naar het begin. je ball word dus toegevoegd vanuit een ander script
        } else if (touched > 1) {
            touched = touched - 1;
            // dit zorgt ervoor dat je op het goeie stadium blijft als je mydocuments aanraakt en nog niet de goeie office iconen hebt aangeraakt
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        touched = touched + 1;
        // als de ball het mydocuments icoon raakt, word er een stadium toegevoegd. deze word er ergens anders afgehaald als dit nog niet kan/mag
    }
    
}
