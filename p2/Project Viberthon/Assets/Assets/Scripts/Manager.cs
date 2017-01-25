using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{   
    public List<Image> images = new List<Image>();
    public List<Image> worldimage = new List<Image>();
    public List<GameObject> hitbox = new List<GameObject>();
    public Vector3 spawn;
    public GameObject capsule;
    public GameObject cam;
    public int tabletsHit;
    public int loopInt;
    public GameObject items;
    public Image menu;
    public Button quit;
    public Button cont;
    public Button rest;
    public Text tquit;
    public Text tcont;
    public Text trest;

    void Start()
    {
        reset();
        pauze();
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel") == true)
        {
            pauze();
        }
    }
    public void loop()
    {
        loopInt = 0;
        for (int i = 0; i < hitbox.Count; i++)
        {
            
            if (hitbox[i].GetComponent<TabletTrigger>().hit == true)
            {
                images[i].GetComponent<Image>().enabled = true;
                worldimage[i].GetComponent<Image>().enabled = false;
                loopInt += 1;
            } 
        }
        tabletsHit = loopInt;
    }
    public void reset()
    {
        capsule.GetComponent<Transform>().position = spawn;
        tabletsHit = 0;
        for (int i = 0; i < images.Count; i++)
        {
            images[i].GetComponent<Image>().enabled = false;
        }
        for (int i = 0; i < worldimage.Count; i++)
        {
            worldimage[i].GetComponent<Image>().enabled = true;
        }
        for (int i = 0; i < hitbox.Count; i++)
        {
            hitbox[i].GetComponent<TabletTrigger>().hit = false;
        }
        items.GetComponent<Items>().Restart();
    }
    public void pauze()
    {
        Cursor.lockState = CursorLockMode.None;
        menu.GetComponent<Image>().enabled = true;
        quit.GetComponent<Button>().enabled = true;
        cont.GetComponent<Button>().enabled = true;
        rest.GetComponent<Button>().enabled = true;
        tquit.GetComponent<Text>().enabled = true;
        tcont.GetComponent<Text>().enabled = true;
        trest.GetComponent<Text>().enabled = true;
        cam.GetComponent<CamMouseLook>().enabled = false;
        capsule.GetComponent<CharacterController>().enabled = false;
    }
    public void pauzereset()
    {
        Cursor.lockState = CursorLockMode.Locked;
        menu.GetComponent<Image>().enabled = false;
        quit.GetComponent<Button>().enabled = false;
        cont.GetComponent<Button>().enabled = false;
        rest.GetComponent<Button>().enabled = false;
        tquit.GetComponent<Text>().enabled = false;
        tcont.GetComponent<Text>().enabled = false;
        trest.GetComponent<Text>().enabled = false;
        cam.GetComponent<CamMouseLook>().enabled = true;
        capsule.GetComponent<CharacterController>().enabled = true;
    }
    public void quitgame()
    {
        Application.Quit();
    }
}
