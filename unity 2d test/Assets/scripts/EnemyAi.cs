using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public GameObject ThePlayer;

    public float range;
    public float speed;

    public Vector2 Poin1;
    public Vector2 Point2;

    public bool OnPoint1;
    public bool OnPoint2;

    public bool IsStunned = false;


    // Start is called before the first frame update
    void Start()
    {
        ThePlayer = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, ThePlayer.transform.position) < range)
        {

            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, speed * Time.deltaTime);

            if (ThePlayer.transform.position.x > transform.position.x)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else if (ThePlayer.transform.position.x < transform.position.x)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
        }
        else
        {
            
        }
       


    }
}
