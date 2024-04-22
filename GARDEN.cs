using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GARDEN : MonoBehaviour
{
    public GameObject ovoshe;
    public bool rost;
    // Start is called before the first frame update
    void Start()
    {
        ovoshe.SetActive(false);
        rost = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Timer() {
        rost = true;
        yield return new WaitForSeconds(5);
        print("ќвощи выросли");
        ovoshe.SetActive(true);

    }
}
