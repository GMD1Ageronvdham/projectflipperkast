using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public float speed;
    public float jumpspeed;
    public float flyjumps;
    public float maxjumps;
	void Start () {
		
	}

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;

        transform.Translate(horizontal, 0, 0);
        if (Input.GetButtonDown("Jump") && flyjumps < maxjumps)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpspeed);
            flyjumps += 1;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        flyjumps = 0;
    }

}
