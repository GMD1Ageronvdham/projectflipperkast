using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheating2 : MonoBehaviour
{

    public GameProgress progress;
    public void OnTriggerEnter()
    {
        progress.ProgressEight();
    }
}
