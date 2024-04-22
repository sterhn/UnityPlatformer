using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : MonoBehaviour
{
    bool vghragce;
    GARDEN gradca;
    public int semena;
    public int ovoshsbor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vghragce==true&& Input.GetKeyDown(KeyCode.E) && semena > 0 && gradca.rost==false)
        {
            semena = semena - 1;
            vghragce = false;
            StartCoroutine(gradca.Timer());

        }
        if (vghragce == true && Input.GetKeyDown(KeyCode.E) && gradca.ovoshe.activeSelf == true)
        {
            print("Мы собрали");
            ovoshsbor = ovoshsbor + 1;
            gradca.rost = false;
            gradca.ovoshe.SetActive(false);
            vghragce = false;

        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Грядка")
        {
            vghragce = true;
            gradca = other.GetComponent<GARDEN>();
          
        }
        if (other.tag =="Семена" )
        {
            semena = 5;
        }    
    }
}
