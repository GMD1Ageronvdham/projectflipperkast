﻿using UnityEngine;
using System.Collections;
// dit is het script voor het bewegen van de linker flipper
// alles is hetzelfde als in het FlipperMoveRight script behalve de keycode voor de knop
// daarom: zie FlipperMoveRight voor uitleg
public class FlipperMoveLeft : MonoBehaviour
{
    public bool flipactivated;
    public bool activeFlipper;
    public bool deactiveFlipper;
    public bool buttonhold;
    public bool endoftheline;
    public bool flipperactive;
    public float timer1 = 0;
    public float timer2 = 0;
    public float speed;
    public GameObject flipperLinks;
    public Vector3 endplace;
    public Vector3 startplace;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && flipactivated == false)
        {
            activeFlipper = true;
            buttonhold = true;
            flipactivated = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            buttonhold = false;
        }
        if (timer1 > 12f)
        {

            activeFlipper = false;
            endoftheline = true;
            timer1 = 0;
            transform.localEulerAngles = endplace;
        }
        if (buttonhold == false && endoftheline == true)
        {
            deactiveFlipper = true;
        }

        if (timer2 > 12f)
        {
            deactiveFlipper = false;
            timer2 = 0;
            flipactivated = false;
            transform.localEulerAngles = startplace;
        }
        if (activeFlipper == true)
        {
            transform.RotateAround
                (transform.position,
                flipperLinks.transform.up,
                -200 * Time.deltaTime);
            timer1 = timer1 + (Time.deltaTime * 100);
        }
        if (deactiveFlipper == true)
        {
            transform.RotateAround
               (transform.position,
               flipperLinks.transform.up,
               200 * Time.deltaTime);
            timer2 = timer2 + (Time.deltaTime * 100);
            endoftheline = false;
        }
    }
}
