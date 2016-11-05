using UnityEngine;
using System.Collections;

public class BallFired : MonoBehaviour
{
    public bool playing;

    void Update()
    {
        if (GameObject.Find("Dead").GetComponent<DeadDetect>().touch == true)
        {
            playing = false;
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
