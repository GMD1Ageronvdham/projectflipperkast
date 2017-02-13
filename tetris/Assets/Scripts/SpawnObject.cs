using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public List<float> rotations = new List<float>();
    public List<GameObject> prefabs = new List<GameObject>();
    public List<int> startpos = new List<int>();
    public List<int> startposver = new List<int>();
    public GamList add;
    public int i;
    public int i2;
    
    public Vector3 spawnpos;

	void Update ()
    {
        if (Input.GetButtonDown("Jump"))
        {
            i = Random.Range(0, 7);
    //        print("i " + i);
            i2 = Random.Range(0, 4);
    //        print("i2 " + i2);
            GameObject g = (GameObject) Instantiate(prefabs[i], spawnpos, Quaternion.identity );
            g.transform.Rotate(new Vector3(0, 0, rotations[i2]));
            add.alive.Add(g);
      //      print("formule " + (i * 10 + i2));
            g.GetComponent<Fallstop>().starttype = startpos[i * 10 + i2];
            g.GetComponent<Fallstop>().starttypever = startposver[i * 10 + i2];
            g.GetComponent<Fallstop>().isplayer = true;
            g.GetComponent<Fallstop>().prefab = i;
            g.GetComponent<Fallstop>().rotation = i2;
            g.GetComponent<Fallstop>().spawn = this;
            g.GetComponent<Fallstop>().thisobject = g;
        }
	}
}
