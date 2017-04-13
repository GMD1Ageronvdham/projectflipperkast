using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour {

    public GameObject shopText;
    public Move move;
    public GameProgress progress;
    public UIJumpTime uiJumpTime;
   

    void Start ()
    {
        shopText.SetActive(false);
	}
	
	void Update ()
    {
		
	}
    public void OnTriggerEnter(Collider other)
    {
        print("hoi");
        shopText.SetActive(true);
    }
    public void BuyFlyTime()
    {
        if (progress.honey > 1)
        {
            move.flytimemod += 0.5f;
            progress.honey -= 2;
            progress.UpdateItemCount();
            uiJumpTime.Instant();
        }
    }
    public void BuyWalkingSpeed()
    {
        if (progress.honeypots > 1)
        {
            move.walktimemod += 0.05f;
            progress.honeypots -= 2;
            progress.UpdateItemCount();
            uiJumpTime.Instant();
        }
    }
}
