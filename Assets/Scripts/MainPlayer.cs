    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class MainPlayer : MonoBehaviour
    {

        //Player Movement variable
        public float speed = 5;
        Rigidbody rig;

        //Sounds
        AudioSource Audio;
        public AudioClip eatSound;

        AudioSource Audios;
        public AudioClip damageSound;

        AudioSource Audiox;
        public AudioClip healtSound;
        

    // Start is called before the first frame update
    void Start()
        {
            rig = GetComponent<Rigidbody>();
            Audio = gameObject.GetComponent<AudioSource>();
            Audios = gameObject.GetComponent<AudioSource>();
            Audiox = gameObject.GetComponent<AudioSource>();
    }

        // Update is called once per frame
        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.Rotate(Vector3.up, horizontal);
            rig.velocity = transform.forward * vertical * speed + new Vector3(0, rig.velocity.y, 0);
        
        }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            Audios.PlayOneShot(damageSound);
        }
        else if (collision.gameObject.CompareTag("Chatarra"))
        {
            Audio.PlayOneShot(eatSound);
        }
        else if (collision.gameObject.CompareTag("Saludable"))
        {
            Audiox.PlayOneShot(healtSound);
        }
    }
}
