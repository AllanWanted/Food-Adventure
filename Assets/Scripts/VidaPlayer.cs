using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public BarraDeVida barraDeVida;
    public GameObject canvas;
    public Text txtplayer;





    void Update()
    {
        
    }

    public void HitSaludable()
    {
        vida = vida - 5;
        barraDeVida.vidaActual = vida;
        if(vida <= 0)
        {
            canvas.SetActive(true);
            txtplayer.text = "Perdiste";
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Saludable"))
        {
            HitSaludable();
        }
    }

    



   
}
