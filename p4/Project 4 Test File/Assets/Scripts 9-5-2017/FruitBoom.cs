using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBoom : MonoBehaviour
{
    public Apple appel;
    public Banaan banana;
    public Fruit fruit;

	void Start ()
    {
        appel = new Apple();
        print(appel.giftig);
        fruit = appel;
        fruit.Pel();
	}
	
	void Update ()
    {
		
	}
}
