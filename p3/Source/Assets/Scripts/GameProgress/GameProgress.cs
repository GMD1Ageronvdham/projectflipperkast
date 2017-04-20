using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameProgress : MonoBehaviour
{
    public int progress;
    public int difficulty;
    public Move move;
    public GameObject player;
    public GameObject partOne;
    public bool timerdone;
    public int honeypots;
    public int honey;
    public UIManager uiManager;
    public AudioSource playClips;
    public GameObject canvas;
    //0. epilogue
    public List<Image> nerratorImages = new List<Image>();
    public AudioClip introclip;
    //1. started game, bee starts falling
    //2. go up to the hive.
    //3. DayNightCycle
    public bool daycycle;
    public bool nightcyle;
    public Color colorOne;
    public Color colorTwo;
    public Camera cutscene1;
    public Material skybox;
    public float colorchangespeed;
    public float t;
    //4. new day starts
    public GameObject partTwo;
    //5. visited the shop
    public GameObject partThree;
    //6. on a quest
    public AudioClip questOneClip;
    public GameObject partFour;
    //7. quest number 2
    public AudioClip questTwoClip;
    //8. 
    public GameObject partFive;
    public Animator credits;
    public AudioClip endDialogue;

    void Start()
    {
        skybox.SetColor("_Tint", colorOne);
        canvas.SetActive(true);
        difficulty = 1;
        partOne.SetActive(false);
        partTwo.SetActive(false);
        cutscene1.GetComponent<Camera>().enabled = false;
        cutscene1.GetComponent<AudioListener>().enabled = false;
        partThree.SetActive(false);
        partFour.SetActive(false);
        for (int i = 0; i < nerratorImages.Count; i++)
        {
            nerratorImages[i].enabled = false;
        }
    }

    void Update()
    {
        if (daycycle == true)
        {
            skybox.SetColor("_Tint",Color.Lerp(colorOne, colorTwo, t));
            if (t < 1)
            {
                t += Time.deltaTime / colorchangespeed;
            }
            if (t > 1)
            {
                t = 0;
                daycycle = false;
                nightcyle = true;
            }
        }
        if (nightcyle == true)
        {
            skybox.SetColor("_Tint", Color.Lerp(colorTwo, colorOne, t));
            if (t < 1)
            {
                t += Time.deltaTime / colorchangespeed;
            }
        }
        if (progress == 3)
        {
            if (timerdone == true)
            {
                cutscene1.GetComponent<Camera>().enabled = false;
                cutscene1.GetComponent<AudioListener>().enabled = false;
                ProgressFour();
                progress = 4;
            }
        }
    }
    public void UpdateItemCount()
    {
        uiManager.UpdateItemCount();
    }
    public void Epilogue()
    {
        playClips.clip = introclip;
        playClips.Play();
        StartCoroutine(EpilogueText());
    }
    public void ProgressOne()
    {
        player.transform.position = (new Vector3(165, 175, 0));
        move.status = Move.state.Fall;
        move.anim.SetBool("Idle", false);
        move.anim.SetBool("Fall", true);
        progress = 2;
        partOne.SetActive(true);
    }
    public void ProgressThree()
    {
        player.SetActive(false);
        partOne.SetActive(false);
        cutscene1.GetComponent<Camera>().enabled = true;
        cutscene1.GetComponent<AudioListener>().enabled = true;
        daycycle = true;
        StartCoroutine(Timer(20));
    }
    public void ProgressFour()
    {
        player.SetActive(true);
        partTwo.SetActive(true);
    }
    public void ProgressFive()
    {
        partTwo.SetActive(false);
        partThree.SetActive(true);
    }
    public void DialogueTwo()
    {
        partThree.SetActive(false);
        playClips.clip = questOneClip;
        playClips.Play();
        StartCoroutine(QuestOneText());
    }
    public void ProgressSix()
    {
        partFour.SetActive(true);
        player.transform.position = (new Vector3(550, 34.5f, 0));
    }
    public void ProgressSeven()
    {
        partFour.SetActive(false);
        playClips.clip = questTwoClip;
        playClips.Play();
        StartCoroutine(QuestTwoText());
    }
    public void ProgressEight()
    {
        partFive.SetActive(true);
        player.transform.position = (new Vector3(1450, 0, 0));
    }
    public void End()
    {
        StartCoroutine(EndText());
        playClips.clip = endDialogue;
        playClips.Play();
    }
    public void updateDifficulty()
    {
        if (difficulty == 1)
        {
            move.maxflytime = 6f;
        }
        if (difficulty == 2)
        {
            move.maxflytime = 5.5f;
        }
        if (difficulty == 3)
        {
            move.maxflytime = 5f;
        }
        if (difficulty == 4)
        {
            move.maxflytime = 4.5f;
        }
    }
    public IEnumerator Timer(int i)
    {
        yield return new WaitForSeconds(i);
        timerdone = true;
    }
    public IEnumerator EpilogueText()
    {
        nerratorImages[0].enabled = true;
        yield return new WaitForSeconds(6);
        nerratorImages[0].enabled = false;
        nerratorImages[1].enabled = true;
        yield return new WaitForSeconds(5.5f);
        nerratorImages[1].enabled = false;
        nerratorImages[2].enabled = true;
        yield return new WaitForSeconds(9.5f);
        nerratorImages[2].enabled = false;
        nerratorImages[3].enabled = true;
        yield return new WaitForSeconds(8.5f);
        nerratorImages[3].enabled = false;
        playClips.clip = null;
        uiManager.Game();
        ProgressOne();
    }
    public IEnumerator QuestOneText()
    {
        nerratorImages[4].enabled = true;
        yield return new WaitForSeconds(6);
        nerratorImages[4].enabled = false;
        nerratorImages[5].enabled = true;
        yield return new WaitForSeconds(3.5f);
        nerratorImages[5].enabled = false;
        nerratorImages[6].enabled = true;
        yield return new WaitForSeconds(5.5f);
        nerratorImages[6].enabled = false;
        nerratorImages[7].enabled = true;
        yield return new WaitForSeconds(11);
        nerratorImages[7].enabled = false;
        playClips.clip = null;
        ProgressSix();
    }
    public IEnumerator QuestTwoText()
    {
        nerratorImages[8].enabled = true;
        yield return new WaitForSeconds(5);
        nerratorImages[8].enabled = false;
        nerratorImages[9].enabled = true;
        yield return new WaitForSeconds(10);
        nerratorImages[9].enabled = false;
        nerratorImages[10].enabled = true;
        yield return new WaitForSeconds(7);
        nerratorImages[10].enabled = false;
        nerratorImages[11].enabled = true;
        yield return new WaitForSeconds(8);
        nerratorImages[11].enabled = false;
        nerratorImages[12].enabled = true;
        yield return new WaitForSeconds(11);
        nerratorImages[12].enabled = false;
        nerratorImages[13].enabled = true;
        yield return new WaitForSeconds(8);
        nerratorImages[13].enabled = false;
        nerratorImages[14].enabled = true;
        yield return new WaitForSeconds(12);
        nerratorImages[14].enabled = false;
        playClips.clip = null;
        ProgressEight();
    }
    public IEnumerator EndText()
    {
        nerratorImages[15].enabled = true;
        yield return new WaitForSeconds(4);
        nerratorImages[15].enabled = false;
        nerratorImages[16].enabled = true;
        yield return new WaitForSeconds(7);
        nerratorImages[16].enabled = false;
        nerratorImages[17].enabled = true;
        yield return new WaitForSeconds(7);
        nerratorImages[17].enabled = false;
        nerratorImages[18].enabled = true;
        yield return new WaitForSeconds(10.5f);
        nerratorImages[18].enabled = false;
        nerratorImages[19].enabled = true;
        yield return new WaitForSeconds(8);
        nerratorImages[19].enabled = false;
        nerratorImages[20].enabled = true;
        yield return new WaitForSeconds(8);
        nerratorImages[20].enabled = false;
        nerratorImages[21].enabled = true;
        yield return new WaitForSeconds(6.5f);
        nerratorImages[21].enabled = false;
        nerratorImages[22].enabled = true;
        yield return new WaitForSeconds(10);
        nerratorImages[24].enabled = true;
        credits.SetBool("Credits", true);
        yield return new WaitForSeconds(8);
        nerratorImages[23].enabled = true;
        yield return new WaitForSeconds(8);
        nerratorImages[24].enabled = false;
        playClips.clip = null;
    }
}
