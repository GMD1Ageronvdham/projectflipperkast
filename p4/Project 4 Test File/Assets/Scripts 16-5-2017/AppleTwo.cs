using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTwo : FruitTwo
{
    public override void Pluk()
    {
        print("hello");
        //throw new NotImplementedException();
    }
    public override void Peel()
    {
        print("ik sta in de apple");
    }
}
