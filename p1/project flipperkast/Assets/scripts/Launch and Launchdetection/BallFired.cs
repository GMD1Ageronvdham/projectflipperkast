using UnityEngine;
using System.Collections;
// dit script registreert of de ball is afgevuurt en in het veld is belang
public class BallFired : MonoBehaviour
{
    public bool playing;

    void Update()
    {
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            playing = false;
            // hier word de fence gereset als je af bent. het effect van deze boolean zal je merken in het "Fence" script
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            playing = true;
        }
    }
}
