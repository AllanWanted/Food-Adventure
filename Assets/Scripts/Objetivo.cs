using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo : MonoBehaviour
{
    public AudioSource quienEmite;
    public AudioClip elSonido;
    public float volumen = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
            {
                quienEmite.PlayOneShot(elSonido, volumen);
                Destroy(gameObject);

            }
    }
}
