using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameManager manager;
    public GameObject player;
    public Camera menuCamera;
    public GameProgress progress;
    //startmenu
    public GameObject startMenu;
    public Animator menuBeeAnim;
    //optionsmenu
    public GameObject optionsMenu;
    public Text difficultyText;
    public GameObject beeMenu;
    public int beeAnimState;
    //gameoverlay
    public GameObject gameOverlay;
    public Text presE;
    public Text playerText;
    public Text playerchoice;
    public UIJumpTime uiJump;
    public Text honey;
    public Text honeyPot;
    public Image playerIm1;
    public Image playerIm2;
    public Image pressEImage;

    void Start ()
    {
        gameOverlay.SetActive(false);
        optionsMenu.SetActive(false);
        beeMenu.SetActive(false);
        progress.updateDifficulty();
        playerText.text = ("");
        playerchoice.enabled = false;
        playerIm1.enabled = false;
        playerIm2.enabled = false;
        pressEImage.enabled = false;
    }
	
	void Update ()
    {
		
	}
    public void Menu ()
    {
        startMenu.SetActive(true);
        gameOverlay.SetActive(false);
        player.SetActive(false);
    }
    public void NewGame()
    {
        Game();
        manager.NewGame();
        menuCamera.GetComponent<Camera>().enabled = false;
    }
    public void Options()
    {
        startMenu.SetActive(false);
        optionsMenu.SetActive(true);
        beeAnimState = 0;
        menuBeeAnim.SetInteger("State", beeAnimState);
        beeMenu.SetActive(true);
        difficultyText.text = progress.difficulty.ToString();
    }
    public void DifficultyPlus()
    {
        if (progress.difficulty < 4)
        {
            progress.difficulty = progress.difficulty + 1;
            difficultyText.text = progress.difficulty.ToString();
        }
    }
    public void DifficultyMin()
    {
        if (progress.difficulty > 1)
        {
            progress.difficulty = progress.difficulty - 1;
            difficultyText.text = progress.difficulty.ToString();
        }
    }
    public void UpdateItemCount()
    {
        honey.text = progress.honey.ToString();
        honeyPot.text = progress.honeypots.ToString();
    }
    public void Character()
    {
        beeAnimState += 1;
        if (beeAnimState > 3)
        {
            beeAnimState = 0;
        }
        menuBeeAnim.SetInteger("State", beeAnimState);
    }
    public void optionsBack()
    {
        startMenu.SetActive(true);
        optionsMenu.SetActive(false);
        beeMenu.SetActive(false);
        progress.updateDifficulty();
    }
    public void Game()
    {
        startMenu.SetActive(false);
        gameOverlay.SetActive(true);
        uiJump.Instant();
        player.SetActive(true);
        menuCamera.GetComponent<Camera>().enabled = false;
        presE.enabled = false;
    }

}
