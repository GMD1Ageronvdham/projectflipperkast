using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    public GameObject shopText;
    public Text jumpAmount;
    public Text walkAmount;
    public Move move;
    public GameProgress progress;
    public UIJumpTime uiJumpTime;
    public bool updateNumbers;
   

    void Start ()
    {
        shopText.SetActive(false);
	}
	
	void Update ()
    {
		if (updateNumbers == true)
        {
            jumpAmount.text = uiJumpTime.flytimeint.ToString();
            walkAmount.text = (Convert.ToInt32((move.walkspeed + move.walktimemod) * 100)).ToString();
        }
	}
    public void OnTriggerEnter(Collider other)
    {
        shopText.SetActive(true);
        updateNumbers = true;
    }
    public void OnTriggerExit(Collider other)
    {
        shopText.SetActive(false);
        updateNumbers = false;
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
            move.walktimemod += 0.01f;
            progress.honeypots -= 2;
            progress.UpdateItemCount();
            uiJumpTime.Instant();
        }
    }
}
