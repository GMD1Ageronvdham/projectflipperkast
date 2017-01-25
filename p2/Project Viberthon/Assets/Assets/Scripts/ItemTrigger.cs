using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{

    public GameObject items;
    public bool hit;

    void OnTriggerEnter(Collider other)
    {
        hit = true;
        items.GetComponent<Items>().ItemStart();
    }
}
