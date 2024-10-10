using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amy1Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;

    CharacterController characterController;
    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();

        anim.SetBool("isDef", false);
        anim.SetBool("isWalking", false);
        anim.SetBool("isDancing", false);
        //Time to start the animation
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isDancing", true);
            anim.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isDef", true);
            anim.SetBool("isDancing", false);
        }
    }
}
