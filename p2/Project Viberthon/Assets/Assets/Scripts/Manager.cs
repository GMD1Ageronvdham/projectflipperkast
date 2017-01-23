using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    public List<bool> boollist = new List<bool>();
    public List<Image> images = new List<Image>();
    public List<Image> worldimage = new List<Image>();
    public List<GameObject> hitbox = new List<GameObject>();
    public bool runloop;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel") == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if (runloop == true)
        {
            loop();
        }
    }
    void loop()
    {
        for (int i = 0; i < hitbox.Count; i++)
        {
            if (hitbox[i].GetComponent<TabletTrigger>().hit == true)
            {
                //print(images[i].GetComponent<Image>());
                images[i].GetComponent<Image>().enabled = true;
                worldimage[i].GetComponent<Image>().enabled = false;
                boollist[i] = true;
               // print("hoi");
            }
        }
        runloop = false;
    }
}
