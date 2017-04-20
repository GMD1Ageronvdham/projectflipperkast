using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheating1 : MonoBehaviour
{

    public GameProgress progress;
    public void OnTriggerEnter()
    {
        progress.ProgressSix();
    }
}
