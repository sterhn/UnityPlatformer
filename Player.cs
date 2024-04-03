using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

public GameObject pausePanel;
    public int speed = 5, jump = 10;
    public Animator anim;
    public bool ground;
    public AudioSource jumpSFX;
    public int coins;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("coins"))
        {
            coins = PlayerPrefs.GetInt("coins");

        
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
{
	Time.timeScale = 0;
	pausePanel.SetActive(true);
}

        rb.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && ground == true)
        {
            
            anim.SetBool("grounded", false);
            rb.velocity = new Vector2(rb.velocity.x, jump);
            ground = false;
            jumpSFX.Play();
        }
        if (rb.velocity.x>0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
     
         }
        if (rb.velocity.x<0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        anim.SetBool("run", rb.velocity.x != 0);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        anim.SetBool("grounded", true);
        ground = true;
    }

}
