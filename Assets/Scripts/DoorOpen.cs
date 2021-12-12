using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;

    private bool doorOpen = false;

    private void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if (!doorOpen)
        {
            anim.Play("DoorOpen", 0, 0.0f);
            doorOpen = true;
        }
        else
        {
            anim.Play("DoorClose", 0, 0.0f);
            doorOpen = false;
        }
    }
}
    /*Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("IsOpen", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool("IsOpen", false);
        }
    }
}*/
