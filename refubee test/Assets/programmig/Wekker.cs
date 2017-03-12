using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wekker{

	void Start () {
		
	}
	void Update () {
		
	}
    public IEnumerator Test(float f)
    {
        yield return new WaitForSeconds(f);
       // print("hoi");
    }
}
