using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallstop : MonoBehaviour {

    public List<GameObject> kids = new List<GameObject>();
    public GamList listscript;
    public SpawnObject spawn;
    public GameObject thisobject;
    public int value;
    public int valueleft;
    public int valueright;
    public int starttype;
    public int starttypever;
    public bool isplayer;
    public int prefab;
    public int rotation;

    void Start () {
        listscript = GameObject.Find("spawn").GetComponent<GamList>();
	}
    public void loopleft()
    {
        for (int i = 0; i < kids.Count; i++)
        {
            if (kids[i].GetComponent<detectcol>().left == true)
            {
                valueleft += 1;
            }
        }
        if (valueleft == starttypever)
        {
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
        for (int i = 0; i < kids.Count; i++)
        {
            kids[i].GetComponent<detectcol>().left = false;
        }
        valueleft = 0;
    }
    public void loopright()
    {
        for (int i = 0; i < kids.Count; i++)
        {
            if (kids[i].GetComponent<detectcol>().right == true)
            {
                valueright += 1;
            }
        }
        if (valueright == starttypever)
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
        for (int i = 0; i < kids.Count; i++)
        {
            kids[i].GetComponent<detectcol>().right = false;
        }
        valueright = 0;
    }
    public void loop()
    {
        for (int i = 0; i < kids.Count; i++)
        {
            if(kids[i].GetComponent<detectcol>().emptydown == true)
            {
                value += 1;
            }
        }
        print(value);
        if (value == starttype)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
        for (int i = 0; i < kids.Count; i++)
        {
            kids[i].GetComponent<detectcol>().emptydown = false;
            kids[i].GetComponent<detectcol>().ableToFall = false;
        }
        value = 0;
    }
    public void rotate()
    {
        if (prefab != 1)
        {
            if (rotation != 3)
            {
                rotation += 1;
                thisobject.transform.Rotate(new Vector3(0, 0, spawn.rotations[rotation]));
                starttype = spawn.startpos[prefab * 10 + rotation];
                starttypever = spawn.startposver[prefab * 10 + rotation];
            }
            if (rotation == 3)
            {
                thisobject.GetComponent<Transform>().Rotate(new Vector3(0, 0, spawn.rotations[0]));
                starttype = spawn.startpos[prefab * 10 + rotation];
                starttypever = spawn.startposver[prefab * 10 + rotation];
            }       
        }
    }
}
