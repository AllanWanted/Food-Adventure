using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPlayer : MonoBehaviour
{

    //Player Movement variable
    public float speed = 5;
    Rigidbody rig;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, horizontal);
        rig.velocity = transform.forward * vertical * speed + new Vector3(0, rig.velocity.y, 0);

    }
}
