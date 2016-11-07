using UnityEngine;
using System.Collections;
// dit script word op bijna alle icoontjes gebruikt om de score toe te voegen
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
            // dit is een timer touched voor een halve seconde aanhoud voor andere scripts om te gebruiken
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
        // de score word intern opgeteld. deze word door het algemene score script opgeteld
    }
}
