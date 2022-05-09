using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public GameObject canvas1;
    public Text txtplayer;

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.name == "triggermeta")
        {
            Debug.Log("Colisionando");
            canvas1.SetActive(true);
            txtplayer.text = "Ganaste";
        }

        
    }

    
}
