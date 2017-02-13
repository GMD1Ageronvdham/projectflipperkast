using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamList : MonoBehaviour
{ 
    public List<Collider> blocks = new List<Collider>();
    public List<GameObject> alive = new List<GameObject>();
    public List<Vector3> grid = new List<Vector3>();
    public bool next;
    public float timer;

	void Update ()
    {
        timer = timer + Time.deltaTime;
        if (timer > 0.5f)
        {
            loop();
            timer = 0;
            next = true;
        }
        if (Input.GetButtonDown("A"))
        {
            left();
            next = true;
        }
        if (Input.GetButtonDown("D"))
        {
            right();
            next = true;
        }
        if (Input.GetButtonDown("W"))
        {
            timer = 0;
            for (int i = 0; i < alive.Count; i++)
            {
                if (alive[i].GetComponent<Fallstop>().isplayer == true)
                {
                    alive[i].GetComponent<Fallstop>().rotate();
                    loop();
                }
            }
        }
	}
    public void loop()
    {
        for (int i = 0; i < blocks.Count; i++)
        {
            if (blocks[i] != null && i > 10 && blocks[i - 10] == null)
            {
                blocks[i].GetComponent<detectcol>().ableToFall = true;
                blocks[i].GetComponent<detectcol>().emptydown = true;
            } else
            {
                for (int r = 0; i < alive.Count; i++)
                {
                    if (i > 10 && blocks[i-1] != null)
                    {
                        alive[r].GetComponent<Fallstop>().isplayer = false;
                    }
                }
            }
        }
        for (int i = 0; i < alive.Count; i++)
        {
                alive[i].GetComponent<Fallstop>().loop();
        }
        next = false;
    }
    public void left()
    {
        print("hoi1");
        for (int i = 0; i < blocks.Count; i++)
        {
            if (blocks[i] != null && blocks[i].GetComponent<detectcol>().isplaying == true)
            {
                print("hoi2");
                if (blocks[i] != null && blocks[i - 1] == null && blocks[i].GetComponent<detectcol>().height * 10 + 1 != i)
                {
                    blocks[i].GetComponent<detectcol>().left = true;
                    print("hoi3");
                }
            }
        }
        for (int i = 0; i < alive.Count; i++)
        {
            if (alive[i].GetComponent<Fallstop>().isplayer == true)
            {
                alive[i].GetComponent<Fallstop>().loopleft();
                print("hoi4");
            }
        }
        next = false;
    }
    public void right()
    {
        print("rhoi1");
        for (int i = 0; i < blocks.Count; i++)
        {
            if (blocks[i] != null && blocks[i].GetComponent<detectcol>().isplaying == true)
            {
                print("rhoi2");
                if (blocks[i] != null && blocks[i + 1] == null && (blocks[i].GetComponent<detectcol>().height + 1) * 10 != i)
                {
                    print("debug" + (blocks[i].GetComponent<detectcol>().height + 1) * 10);
                    blocks[i].GetComponent<detectcol>().right = true;
                    print("rhoi3");
                }
            }
        }
        for (int i = 0; i < alive.Count; i++)
        {
            if (alive[i].GetComponent<Fallstop>().isplayer == true)
            {
                alive[i].GetComponent<Fallstop>().loopright();
                print("rhoi4");
            }
        }
        next = false;
    }
}
