using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour
{
    public GameProgress progress;
    public GameObject honeyPotforNPCTwo;
    public GameObject honeyCombsforNPCR0b0bee;

    void Start()
    {
        honeyPotforNPCTwo.SetActive(false);
        honeyCombsforNPCR0b0bee.SetActive(false);
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
        if (i == 3)
        {
            progress.DialogueTwo();
        }
        if (i == 4)
        {
            honeyCombsforNPCR0b0bee.SetActive(true);
        }
        if (i == 5)
        {
            progress.ProgressSeven();
        }
        if (i == 6)
        {
            progress.End();
        }
    }
}
