using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meta : MonoBehaviour
{
    public GameObject canvas;
    public Text txtplayer;

    private void OnTriggerEnter(Collider player)
    {
        if (player.name == "triggermeta")
        {
            canvas.SetActive(true);
            txtplayer.text = "Ganaste";
        }
    }
}
