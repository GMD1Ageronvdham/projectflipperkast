using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WotrBeeFix : MonoBehaviour
{
    public Vector3 rotation;
	void FixedUpdate ()
    {
        transform.rotation = Quaternion.Euler(rotation);
	}
}
