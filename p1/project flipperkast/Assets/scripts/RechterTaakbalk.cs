using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// dit script enabled de icons in de rechtertaakbalk als deze geraakt zijn
public class RechterTaakbalk : MonoBehaviour {

    void Update()
    {
        if (GameObject.Find("Word").GetComponent<WordExcel>().touched == true)
        {
            GameObject.Find("WordTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("WordTB").GetComponent<RawImage>().enabled = false;
            // word
        }
        if (GameObject.Find("Outlook").GetComponent<OutlookPowerpoint>().touched == true)
        {
            GameObject.Find("OutlookTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("OutlookTB").GetComponent<RawImage>().enabled = false;
            // outlook
        }
        if (GameObject.Find("Publisher").GetComponent<AccesPublisher>().touched == true)
        {
            GameObject.Find("PublisherTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("PublisherTB").GetComponent<RawImage>().enabled = false;
            //publisher
        }
        if (GameObject.Find("Internet").GetComponent<InternetExplorer>().slowness == true)
        {
            GameObject.Find("InternetTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("InternetTB").GetComponent<RawImage>().enabled = false;
            // internet
        }
        if (GameObject.Find("prullebak").GetComponent<TrashCan>().touched == true)
        {
            GameObject.Find("PrullebakTB").GetComponent<RawImage>().enabled = true;
        } else {
            GameObject.Find("PrullebakTB").GetComponent<RawImage>().enabled = false;
            //prullebak
        }
    }
}
