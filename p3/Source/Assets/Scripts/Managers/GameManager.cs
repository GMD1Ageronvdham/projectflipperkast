using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;
    public GameProgress progress;

    void Start ()
    {
        StartScreen();
        progress.progress = 0;
    }
	
	void Update ()
    {
		
	}
    public void StartScreen ()
    {
        uiManager.Menu();
    }
    public void NewGame()
    {
        progress.ProgressOne();
    }

}
