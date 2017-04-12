using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Conversation : MonoBehaviour
{
    public bool onetimeconv;
    public bool talked;
    public List<int> textLoc = new List<int>();
    public List<string> convList = new List<string>();
    public bool playerpos;
    public int count;
    public Text presE;
    public Text PlayerText;
    public Text owntext;
    public Image ownImage;
    public Text PlayerChoice;
    public Image playerImage;
    public Image choiceimage;
    public Image PressEImagee;
    public int action;
    public ConversationManager CManager;
    public bool choice;

    void Start()
    {
        owntext.text = ("");
        ownImage.enabled = false;
    }
    void Update()
    {
        if (count > convList.Count)
        {
                count = 0;
        }
        if (count+1 == convList.Count && onetimeconv == true)
        {
            talked = true;
            presE.enabled = false;
            PressEImagee.enabled = false;
            count = 0;
        }
        if (talked == true && playerpos == true)
        {
            presE.enabled = false;
            PressEImagee.enabled = false;
        }
        if (Input.GetButtonDown("Interact") && playerpos == true && talked == false)
        {
            if (choice == false)
            {
                count += 1;
                if (count > convList.Count - 1)
                {
                    count = 0;
                }
            }
            if (convList[count] == "???")
            {
                choice = true;
                owntext.text = convList[count + 1];
                ownImage.enabled = true;
                PlayerText.text = ("");
                playerImage.enabled = false;
                choiceimage.enabled = true;
                PlayerChoice.enabled = true;
                presE.enabled = false;
                PressEImagee.enabled = false;
            }
            else if (convList[count] == "!!!")
            {
                CManager.Action(action);
                playerpos = false;
                presE.enabled = false;
                owntext.text = ("");
                ownImage.enabled = false;
                PlayerText.text = ("");
                playerImage.enabled = false;
                choiceimage.enabled = false;
                PressEImagee.enabled = false;
                count = 0;
                PlayerChoice.enabled = false;
                choice = false;
            }
            else if (textLoc[count] == 0)
            {
                owntext.text = convList[count];
                ownImage.enabled = true;
                PlayerText.text = ("");
                playerImage.enabled = false;
            }
            else if (textLoc[count] == 1)
            {
                owntext.text = ("");
                ownImage.enabled = false;
                PlayerText.text = convList[count];
                playerImage.enabled = true;
            }
        }
        if (Input.GetButtonDown("1") && choice == true)
        {
            if (convList[count + 2] == "!!!")
            {
                ownImage.enabled = false;
                playerImage.enabled = false;
                CManager.Action(action);
                owntext.text = ("");
                PlayerText.text = ("");
                count += 3;
                choice = false;
                PlayerChoice.enabled = false;
                choiceimage.enabled = false;
                presE.enabled = true;
                PressEImagee.enabled = true;
            }
            else
            {
                owntext.text = convList[count + 2];
                ownImage.enabled = true;
                count += 3;
                choice = false;
                PlayerChoice.enabled = false;
                playerImage.enabled = false;
                choiceimage.enabled = false;
                presE.enabled = true;
                PressEImagee.enabled = true;
            }
        }
        if (Input.GetButtonDown("2") && choice == true)
        {
            if (convList[count + 3] == "!!!")
            {
                ownImage.enabled = false;
                playerImage.enabled = false;
                owntext.text = convList[count + 3];
                CManager.Action(action);
                count += 3;
                choice = false;
                PlayerChoice.enabled = false;
                choiceimage.enabled = false;
                presE.enabled = true;
                PressEImagee.enabled = true;
            }
            else
            {
                owntext.text = convList[count + 3];
                ownImage.enabled = true;
                playerImage.enabled = false;
                count += 3;
                choice = false;
                PlayerChoice.enabled = false;
                choiceimage.enabled = false;
                presE.enabled = true;
                PressEImagee.enabled = true;
            }
        }
    }
    public void OnTriggerEnter()
    {
        playerpos = true;
        PressEImagee.enabled = true;
        if (talked == false)
        {
            presE.enabled = true;
        }
        choiceimage.enabled = false;

    }
    public void OnTriggerExit()
    {
        playerpos = false;
        presE.enabled = false;
        owntext.text = ("");
        ownImage.enabled = false;
        PlayerText.text = ("");
        playerImage.enabled = false;
        choiceimage.enabled = false;
        PressEImagee.enabled = false;
        if (choice == true)
        {
            count = 0;
            PlayerChoice.enabled = false;

        }
        choice = false;
    }
}
