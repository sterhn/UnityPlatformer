using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.Unicode;

public class Enemy : MonoBehaviour
{
    public int speed;
    Transform player;
    int maxd = 10;
    int mind = 2;
    public Animator animator;
   bool flip;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Run", false);
        
        if (Vector3.Distance(transform.position, player.position) <maxd)
        {
           animator.SetBool("Run", true);
            Vector3 scale = transform.localScale;

            if (player.transform.position.x > transform.position.x) {
                scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);
                transform.Translate(speed * Time.deltaTime, 0, 0);
            } 
            else {
                scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);
                transform.Translate(speed * Time.deltaTime * -1, 0, 0);
            }
        
            transform.localScale = scale;
        }

        if (Vector3.Distance(transform.position, player.position) <=mind)
        {
            animator.SetBool("Attack", true);
            // animator.SetBool("Run", false);
        }
        else
        {
            // animator.SetBool("Run", true);
            animator.SetBool("Attack", false);
        }
  
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // if (other.tag == "Player")
        // {
            
        // }
    }
    // void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.tag == "Player")
    //     {
    //         animator.SetBool("Attack", false);
    //     }
    // } 
}
