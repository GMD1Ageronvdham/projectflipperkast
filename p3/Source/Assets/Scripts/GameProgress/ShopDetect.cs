using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopDetect : MonoBehaviour {

    public GameProgress progress;
    
    public void OnTriggerEnter(Collider other)
    {
        if (progress.progress == 4)
        {
            progress.ProgressFive();
        }
    }
}
