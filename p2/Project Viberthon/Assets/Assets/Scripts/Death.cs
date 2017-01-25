using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{ 
    public GameObject manager;
    public GameObject water;
    public float speed;
    public Vector3 pos1;
    public Vector3 pos2;
    public Vector3 pos3;
    public Vector3 pos4;
    public Vector3 pos5;

    void Update()
    {
        float step = speed * Time.deltaTime;
        if (manager.GetComponent<Manager>().tabletsHit == 0)
        {
            water.GetComponent<Transform>().position = pos1;
        }
        if (manager.GetComponent<Manager>().tabletsHit == 1)
        {
            water.GetComponent<Transform>().position = Vector3.MoveTowards(water.GetComponent<Transform>().position, pos2, step);
        }
        if (manager.GetComponent<Manager>().tabletsHit == 2)
        {
            water.GetComponent<Transform>().position = Vector3.MoveTowards(water.GetComponent<Transform>().position, pos3, step);
        }
        if (manager.GetComponent<Manager>().tabletsHit == 3)
        {
            water.GetComponent<Transform>().position = Vector3.MoveTowards(water.GetComponent<Transform>().position, pos4, step);
        }
        if (manager.GetComponent<Manager>().tabletsHit == 4)
        {
            water.GetComponent<Transform>().position = Vector3.MoveTowards(water.GetComponent<Transform>().position, pos5, step);
        }
    }
       
    void OnTriggerEnter(Collider other)
    {
        manager.GetComponent<Manager>().reset();
    }
}
