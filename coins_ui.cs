using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coins_ui : MonoBehaviour

{
    public TextMeshProUGUI textcoins;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textcoins.text = player.coins.ToString();
    }
}
