using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGround : MonoBehaviour
{
    public Move Player;
    public GameObject Trigger;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.position.y < Trigger.transform.position.y && Player.status == Move.state.Fall)
        {
            Player.Fall(collision.transform.position.y);
        }
        if (collision.transform.position.y < Trigger.transform.position.y && Player.status == Move.state.Jump)
        {
            Player.TouchGround(collision.transform.position.y);
        }
        if (Player.easyFall == true)
        {
            Player.anim.SetBool("Jump", false);
            Player.anim.SetBool("Idle", true);
            Player.easyFall = false;
            Player.Fall(collision.transform.position.y);
        }
    }
}
