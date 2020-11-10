using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool CanGoUp = true;
    public bool CanGoDown = true;

    public Rigidbody2D RB;
    public Animator PlayerAnimations;

    public float speed = 10f;
    public float speedUp = 5f;


    // Start is called before the first frame update
    void Start()
    {
        PlayerAnimations = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        RB.velocity = new Vector2(x * speed, y * speedUp);

        if (x >= 0.1)
        {
            PlayerAnimations.SetBool("IsWalking", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        } else if (x <= -0.1)
        {
            PlayerAnimations.SetBool("IsWalking", true);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (y >= 0.1)
        {
            PlayerAnimations.SetBool("IsWalking", true);
            
        }
        else if (y <= -0.1)
        {
            PlayerAnimations.SetBool("IsWalking", true);
            
        }
        else
        {
            PlayerAnimations.SetBool("IsWalking", false);
        }

    }
}
