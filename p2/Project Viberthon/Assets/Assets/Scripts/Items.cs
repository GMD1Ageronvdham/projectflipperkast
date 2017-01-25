using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{
    public Image wscroll1;
    public Image wscroll2;
    public Image scroll1;
    public Image scroll2;
    public Image mscroll1;
    public Image mscroll2;
    public Image mweapon;
    public Text text1;
    public Text text2;
    public GameObject weapon;
    public GameObject rope;
    public GameObject weaponhand;
    public GameObject ropehand;
    public GameObject trigger5;
    public GameObject trigger6;
    public GameObject manager;
    public float timer;
    public bool starttimer;

    void Start ()
    {
        Restart();
	}
	
	void Update ()
    {
        if (manager.GetComponent<Manager>().tabletsHit == 4 && weapon.GetComponent<ItemTrigger>().hit == false)
        {
            weapon.GetComponent<MeshRenderer>().enabled = true;
            weapon.GetComponent<BoxCollider>().enabled = true;
            rope.GetComponent<SkinnedMeshRenderer>().enabled = true;
        }
        if (Input.GetButtonDown("Item1") && trigger5.GetComponent<ItemTrigger>().hit == true && scroll1.GetComponent<Image>().enabled == false)
        {
            scroll1.GetComponent<Image>().enabled = true;
            starttimer = true;
        }
        if (Input.GetButtonDown("Item2") && trigger6.GetComponent<ItemTrigger>().hit == true && scroll2.GetComponent<Image>().enabled == false)
        {
            scroll2.GetComponent<Image>().enabled = true;
            starttimer = true;
        }
        if (starttimer == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (Input.GetButtonDown("Item1") && timer > 0.25f)
        {
            scroll1.GetComponent<Image>().enabled = false;
            scroll2.GetComponent<Image>().enabled = false;
            starttimer = false;
            timer = 0;
            
        }
        if (Input.GetButtonDown("Item2") && timer > 0.25f)
        {
            scroll2.GetComponent<Image>().enabled = false;
            scroll1.GetComponent<Image>().enabled = false;
            starttimer = false;
            timer = 0;
        }
    }
    public void ItemStart()
    {
        if (trigger5.GetComponent<ItemTrigger>().hit == true)
        {
            wscroll1.GetComponent<Image>().enabled = false;
            mscroll1.GetComponent<Image>().enabled = true;
            text1.GetComponent<Text>().enabled = true;
        }
        if (trigger6.GetComponent<ItemTrigger>().hit == true)
        {
            wscroll2.GetComponent<Image>().enabled = false;
            mscroll2.GetComponent<Image>().enabled = true;
            text2.GetComponent<Text>().enabled = true;
        }
        if (weapon.GetComponent<ItemTrigger>().hit == true)
        {
            weapon.GetComponent<MeshRenderer>().enabled = false;
            weapon.GetComponent<BoxCollider>().enabled = false;
            rope.GetComponent<SkinnedMeshRenderer>().enabled = false;
            weaponhand.GetComponent<MeshRenderer>().enabled = true;
            ropehand.GetComponent<SkinnedMeshRenderer>().enabled = true;
            mweapon.GetComponent<Image>().enabled = true;
        }
    }
    public void Restart()
    {
        wscroll1.GetComponent<Image>().enabled = true;
        mscroll1.GetComponent<Image>().enabled = false;
        text1.GetComponent<Text>().enabled = false;
        wscroll2.GetComponent<Image>().enabled = true;
        mscroll2.GetComponent<Image>().enabled = false;
        text2.GetComponent<Text>().enabled = false;
        weapon.GetComponent<MeshRenderer>().enabled = false;
        weapon.GetComponent<BoxCollider>().enabled = false;
        rope.GetComponent<SkinnedMeshRenderer>().enabled = false;
        mweapon.GetComponent<Image>().enabled = false;
        weaponhand.GetComponent<MeshRenderer>().enabled = false;
        ropehand.GetComponent<SkinnedMeshRenderer>().enabled = false;
        weapon.GetComponent<ItemTrigger>().hit = false;
        trigger5.GetComponent<ItemTrigger>().hit = false;
        trigger6.GetComponent<ItemTrigger>().hit = false;
        scroll1.GetComponent<Image>().enabled = false;
        scroll2.GetComponent<Image>().enabled = false;
    }
}