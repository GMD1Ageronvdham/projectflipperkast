using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{

    public bool rijp;
    public bool energy;
    public bool geschild;
    public bool giftig;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
    public virtual void Pel()
    {
        print("fruit");
    }
}
