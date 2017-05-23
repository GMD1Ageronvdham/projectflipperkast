using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FruitTwo : MonoBehaviour
{
    public abstract void Pluk();
    public virtual void Peel()
    {
        print("ik sta in de fruit class");
    }
}
