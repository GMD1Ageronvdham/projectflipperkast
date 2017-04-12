using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelMove : MonoBehaviour
{
    public Move player;
	public void Right()
    {
        transform.position = new Vector3(player.transform.position.x - 1, player.transform.position.y, player.transform.position.z);
        transform.rotation = Quaternion.Euler(0, 90, 0);
        transform.localScale = new Vector3(-50, 50, -50);
    }
    public void Left()
    {
        transform.position = new Vector3(player.transform.position.x + 1, player.transform.position.y, player.transform.position.z);
        transform.rotation = Quaternion.Euler(0, -90, 0);
        transform.localScale = new Vector3(50, 50, -50);
    }
}
