using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// dit script enabled de icons in de linkertaakbalk als deze geraakt zijn
public class LinkerTaakbalk : MonoBehaviour {

	void Update ()
    {
        if (GameObject.Find("Excel").GetComponent<WordExcel>().touched == true)
        {
            GameObject.Find("ExcelTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("ExcelTB").GetComponent<RawImage>().enabled = false;
            //excel
        }
        if (GameObject.Find("Powerpoint").GetComponent<OutlookPowerpoint>().touched == true)
        {
            GameObject.Find("PowerpointTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("PowerpointTB").GetComponent<RawImage>().enabled = false;
            //powerpoint
        }
        if (GameObject.Find("Acces").GetComponent<AccesPublisher>().touched == true)
        {
            GameObject.Find("AccesTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("AccesTB").GetComponent<RawImage>().enabled = false;
            //acces
        }
        if (GameObject.Find("Uitschakelen").GetComponent<Shutdown>().touched == true)
        {
            GameObject.Find("ShutdownTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("ShutdownTB").GetComponent<RawImage>().enabled = false;
            // shutdown
        } 
        if (GameObject.Find("MyDocuments").GetComponent<Documents>().touched > 0)
        {
            GameObject.Find("DocumentsTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("DocumentsTB").GetComponent<RawImage>().enabled = false;
            //documents
        }
    }
}
