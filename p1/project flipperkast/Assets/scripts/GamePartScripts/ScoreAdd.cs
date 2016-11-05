using UnityEngine;
using System.Collections;

public class ScoreAdd : MonoBehaviour {

    public float score;
    public float scoretaken;
    
    void Start () {
	
	}
	
	void Update ()
    {

	}
    public void OnCollisionEnter(Collision collision)
    {
        scoretaken = scoretaken + score;
    }
}
