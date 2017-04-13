using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProgress : MonoBehaviour
{
    public List<GameObject> coll = new List<GameObject>();
    public List<MeshCollider> mesh = new List<MeshCollider>();
    public List<string> questlines = new List<string>();
    public int progress;
    public int difficulty;
    public Move move;
    public GameObject player;
    public GameObject partOne;
    public bool timerdone;
    public int honeypots;
    public int honey;
    public UIManager uiManager;
    //1. started game, bee starts falling
    //2. quest 1. go up to the hive.
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
    //5. visited the shop
    //6. fire starts
    public GameObject fire;

    void Start()
    {
        difficulty = 1;
        partOne.SetActive(false);
        cutscene1.GetComponent<Camera>().enabled = false;
        fire.SetActive(false);
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
                ProgressFour();
                progress = 4;
            }
        }
    }
    public void UpdateItemCount()
    {
        uiManager.UpdateItemCount();
    }
    public void ProgressOne()
    {
        skybox.SetColor("_Tint", colorOne);
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
        daycycle = true;
        StartCoroutine(Timer(20));
    }
    public void ProgressFour()
    {
        player.SetActive(true);
    }
    public void updateDifficulty()
    {
        if (difficulty == 1)
        {
            for (int i = 0; i < coll.Count; i++)
            {
                coll[i].SetActive(true);
            }
            for (int i = 0; i < mesh.Count; i++)
            {
                mesh[i].enabled = false;
            }
            move.maxflytime = 6f;
        }
        if (difficulty == 2)
        {
            for (int i = 0; i < coll.Count; i++)
            {
                coll[i].SetActive(true);
            }
            for (int i = 0; i < mesh.Count; i++)
            {
                mesh[i].enabled = false;
            }
            move.maxflytime = 5.5f;
        }
        if (difficulty == 3)
        {
            for (int i = 0; i < coll.Count; i++)
            {
                coll[i].SetActive(false);
            }
            for (int i = 0; i < mesh.Count; i++)
            {
                mesh[i].enabled = true;
            }
            move.maxflytime = 5f;
        }
        if (difficulty == 4)
        {
            for (int i = 0; i < coll.Count; i++)
            {
                coll[i].SetActive(false);
            }
            for (int i = 0; i < mesh.Count; i++)
            {
                mesh[i].enabled = true;
            }
            move.maxflytime = 4.5f;
        }
    }
    public IEnumerator Timer(int i)
    {
        yield return new WaitForSeconds(i);
        timerdone = true;
    }
}
