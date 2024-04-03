using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenyAttac : MonoBehaviour
{   

    void OnTriggerEnter2D(Collider2D  other){
          if (other.tag == "EnemyHit"){
        Destroy(gameObject);
            }
     //   }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
       
}
