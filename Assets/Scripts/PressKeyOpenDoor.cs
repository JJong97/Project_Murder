using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKeyOpenDoor : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeOject;
    public GameObject ThisTrigger;
    
    public bool Action = false;

    void Start()
    {
        Instruction.SetActive(false);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider collision)
    {
        Instruction.SetActive(false);
        Action = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                AnimeOject.GetComponent<Animator>().Play("DoorOpen");
                ThisTrigger.SetActive(false);
                Action = false;
            }
            if (Action == false)
            {
                Instruction.SetActive(true);
                AnimeOject.GetComponent<Animator>().Play("DoorClose");
                ThisTrigger.SetActive(true);
                Action = true;
            }
        }
    }
}