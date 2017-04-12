using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupItems : MonoBehaviour
{
    public enum type
    {
        Honeypot,
        Honey
    }
    public GameProgress progress;
    public type itemType;

    public void OnCollisionEnter(Collision collision)
    {
        if (itemType == type.Honeypot)
        {
            progress.honeypots++;
            Destroy(gameObject);
            progress.UpdateItemCount();
        }
        if (itemType == type.Honey)
        {
            progress.honey++;
            Destroy(gameObject);
            progress.UpdateItemCount();
        }
    }
}
