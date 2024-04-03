using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class coin : MonoBehaviour
{
    Player player;
    public AudioSource get;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.tag == "Player")
        {
            player = other.GetComponent<Player>();
            player.coins += 1;
            PlayerPrefs.SetInt("coins", player.coins);

            get.Play(); 

            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 0.6f);
            

        }
        
    }
}
