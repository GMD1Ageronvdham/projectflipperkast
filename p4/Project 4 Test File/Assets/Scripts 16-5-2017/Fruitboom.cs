using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitboom : MonoBehaviour
{
    public AppleTwo apple;

	void Start ()
    {
        apple = new AppleTwo();
        apple.Peel();
	}
	
	void Update ()
    {
		
	}
}
