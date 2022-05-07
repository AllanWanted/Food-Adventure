using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public GameObject canvas1;
    public Text txtplayer1;

    private void OnTriggerEnter(Collider player1)
    {
        if (player1.name == "triggermeta")
        {
            canvas1.SetActive(true);
            txtplayer1.text = "Ganaste";
        }
    }
}
