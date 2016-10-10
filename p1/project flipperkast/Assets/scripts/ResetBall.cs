using UnityEngine;
using System.Collections;

public class ResetBall : MonoBehaviour
{

    public bool balreset;

    void update ()
    {
        if (GameObject.Find("bal").GetComponent<Startposition>().reset == true)
            balreset = false;
    }
    public void OnCollisionEnter(Collision collision)
    {
        balreset = true;
    }
}