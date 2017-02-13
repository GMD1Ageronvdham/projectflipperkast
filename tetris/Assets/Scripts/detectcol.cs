using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcol : MonoBehaviour
{
    public bool ableToFall;
    public Fallstop letItFall;
    public bool emptydown;
    public bool isplaying;
    public bool left;
    public bool right;
    public int height;

    void Update()
    {
        if(letItFall.isplayer == true)
        {
            isplaying = true;
        }else
        {
            isplaying = false;
        }
        height = (int)transform.position.y;
        if (height == 0)
        {
            letItFall.isplayer = false;
        }
    }
}
