using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public BarraDeVida barraDeVida;


    
    

    void Update()
    {
        
    }

    public void HitSaludable()
    {
        vida = vida - 10;
        barraDeVida.vidaActual = vida;
        if(vida <= 0)
        {

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.CompareTag("")) ;
    }

    



   
}
