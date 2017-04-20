using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIJumpTime : MonoBehaviour
{
    public bool isjumping;
    public Move move;
    public Text jumpTime;
    public Scrollbar bar;
    public float flytimeper;
    public float flytime;
    public int flytimeint;
    public bool isflying;

    void Start()
    {
        flytimeper = 1;
        flytime = move.maxflytime + move.flytimemod;
    }

    void Update ()
    {
        jumpTime.text = flytimeint.ToString();
        flytimeint = Convert.ToInt32(flytime * 2);
        bar.value = 0;
        bar.size = flytimeper;
        if (isjumping == true)
        {
            flytime = move.maxflytime + move.flytimemod;
            isjumping = false;
            isflying = true;
        }
        if (isflying == true)
        {
            flytime = flytime - Time.deltaTime;
            flytimeper = flytime / (move.maxflytime+move.flytimemod);
        }
        if (flytimeper < 0 || move.status == Move.state.Idle)
        {
            isflying = false;
            flytimeper = 1;
            flytime = move.maxflytime + move.flytimemod;
        }
	}
    public void Instant()
    {
        flytime = move.maxflytime + move.flytimemod;
    }
}
