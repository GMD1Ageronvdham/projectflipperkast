using UnityEngine;
using System.Collections;

public class ScoreAdd : MonoBehaviour {

    public float score;
    public float scoretaken;
    public float timer;
    public bool touched;
    
    void Start () {
	
	}
	
	void Update ()
    {
        if (touched == true)
        {
            timer = timer + Time.deltaTime;
        }
        if (timer > 0.5f)
        {
            touched = false;
            timer = 0;
        }
	}
    public void OnCollisionEnter(Collision collision)
    {
        scoretaken = scoretaken + score;
        touched = true;
    }
}
