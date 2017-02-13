using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridplace : MonoBehaviour {

    public int listloc;
    public GamList ListScript;
    public bool buttonpushed;

    void Update()
    {

    }

    public void OnTriggerEnter(Collider gettriggered)
    {
        ListScript.blocks[listloc] = gettriggered;
    }
    public void OnTriggerExit(Collider leavettrigger)
    {
        ListScript.blocks[listloc] = null;
    }
}
