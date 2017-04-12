using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour
{
    public GameProgress progress;
    public GameObject honeyPotforNPCTwo;

    void Start()
    {
        honeyPotforNPCTwo.SetActive(false);
    }

    public void Action(int i)
    {
        if (i == 1)
        {
            progress.progress = 3;
            progress.ProgressThree();
        }
        if (i == 2)
        {
            honeyPotforNPCTwo.SetActive(true);
        }
    }
}
