using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour
{

    public Animator PlayerAnimations;

    public bool UsingSheild;
    public bool IsUsingSheild;

    public PlayerMovement PM;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimations = gameObject.GetComponent<Animator>();
        PM = gameObject.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            PM.CanWalk = false;
            UsingSheild = true;
            PlayerAnimations.SetBool("Sheild", true);
        }
        else
        {
            PM.CanWalk = true;
            UsingSheild = false;
            PlayerAnimations.SetBool("Sheild", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            MeleeAttack();
        }


    }

    void MeleeAttack()
    {
        PlayerAnimations.SetTrigger("Spear");
    }
}
