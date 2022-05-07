using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private new Rigidbody rigidbody;

    public float speed = 10f;

    public GameObject canvas1;
    public Text txtplayer1;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(hor != 0.0f || ver != 0.0f)
        {
            Vector3 dir = transform.forward * ver + transform.right * hor;

            rigidbody.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("comenzo la colision!");

        
    }

    private void OnTriggerEnter(Collider player1)
    {
        if (player1.name == "triggermeta")
        {
            canvas1.SetActive(true);
            txtplayer1.text = "Ganaste";
        }
    }



    /*private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Estamos Colisionando!");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("termino la colision!");
    }*/
}
