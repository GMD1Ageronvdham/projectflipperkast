using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager UIManager1;
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
        UIManager1.Menu();
    }
    public void NewGame()
    {
        progress.ProgressOne();
    }

}
