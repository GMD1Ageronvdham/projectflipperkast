using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public enum state
    {
        Idle,
        Jump,
        Fall
    }
    public enum direction
    {
        Left,
        Right
    }
    public GameObject player;
    public UIJumpTime uiShow;
    public ModelMove model;
    public Animator anim;  
    public state status;
    public direction richting;
    public float maxflytime;
    public float flytimemod;
    public float flyspeed;
    public float walkspeed;
    public float walktimemod;
    public float step;
    public float fallstep;
    public float easystep;
    public float flystartpos;
    public float landofset;
    public float maxmove;
    public bool timerdone;
    public bool isWalking;
    public bool moveup;
    public bool startjump;
    public bool easyFall;


    void Update ()
    {
        //jump from idle
        if (Input.GetButtonDown("Jump") && status == state.Idle && isWalking == false && easyFall == false && status != state.Fall)
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            StartCoroutine(ResetFall());
            uiShow.isjumping = true;
            startjump = true;
            anim.SetBool("Jump", true);
            anim.SetBool("Idle", false);
            status = state.Jump;
            StartCoroutine(Flytime());
            flystartpos = transform.position.y;
            moveup = true;
        }
        if (Input.GetAxis("Horizontal") > maxmove && status == state.Idle || Input.GetAxis("Horizontal") < -maxmove && status == state.Idle)
        {
            GetComponent<Rigidbody>().useGravity = true;
            isWalking = true;
            anim.SetBool("Idle", false);
            anim.SetBool("Walking", true);
        }
        if (Input.GetAxis("Horizontal") < maxmove && Input.GetAxis("Horizontal") > -maxmove && status == state.Idle)
        {
            isWalking = false;
            anim.SetBool("Idle", true);
            anim.SetBool("Walking", false);
        }
        //peacefull falling from flying
        if (Input.GetButtonDown("Jump") && status == state.Jump && startjump == false)
        {
            StopAllCoroutines();
            easyFall = true;
        }
        //move the bee upwards when he starts flying
        if (moveup == true && flystartpos+1 > transform.position.y)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), step);
        } else
        {
            flystartpos = 0;
            moveup = false;
            startjump = false;
        }
        //dab
        if (Input.GetKeyDown("b") && status == state.Idle)
        {
            anim.SetTrigger("Dab");
        }
        //dance
        if (Input.GetKeyDown("x") && status == state.Idle)
        {
            anim.SetTrigger("Dance");
        }
        //Wave
        if (Input.GetKeyDown("z") && status == state.Idle)
        {
            anim.SetTrigger("Wave");
        }
        //falling
        if (status == state.Fall)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), fallstep);
        }
        //moves bee down in peacefull fall
        if (easyFall == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), easystep);
        }
        //moves bee's direction to left
        if (Input.GetButtonDown("Left"))
        {
            richting = direction.Left;
            model.Left();
        }
        // moves bee's direction to the right
        if (Input.GetButtonDown("Right"))
        {
            richting = direction.Right;
            model.Right();
        }
    }
    void FixedUpdate()
    {
        // moving while flying
        if (status == state.Jump)
        {
            float horizontal = Input.GetAxis("Horizontal") * flyspeed;
            float vertical = Input.GetAxis("Vertical") * flyspeed;
            transform.Translate(horizontal, vertical, 0);
        }
        if (status == state.Idle)
        {
            float horizontal = Input.GetAxis("Horizontal") * (walkspeed + walktimemod);
            transform.Translate(horizontal, 0, 0);
        }
    }
    // resets the bee to idle mode after the fall
    public void Fall(float f)
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, f + landofset, transform.position.z), fallstep);
        status = state.Idle;
        anim.SetBool("Fall", false);
        anim.SetBool("Idle", true);
        GetComponent<Rigidbody>().isKinematic = true;
        StartCoroutine(ResetFall());
        GetComponent<Rigidbody>().useGravity = true;
    }
    public void TouchGround(float f)
    {
        status = state.Idle;
        anim.SetBool("Jump", false);
        anim.SetBool("Idle", true);
        StopAllCoroutines();
        Fall(f);
        GetComponent<Rigidbody>().useGravity = true;
    }
    // max flytime
    public IEnumerator Flytime()
    {
        yield return new WaitForSeconds(maxflytime+flytimemod);
        status = state.Fall;
        anim.SetBool("Jump", false);
        anim.SetBool("Fall", true);
    }
    // helps bee with not moving through objects
    public IEnumerator ResetFall()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
