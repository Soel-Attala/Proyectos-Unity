using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    public float speed = 5f;
    public float hor;
    public float ver;
    public float rotateSpeed;



    void Start()
    {

    }


    void Update()
    {
        MovimientoJugador();

    }


    void MovimientoJugador()
    {
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, ver) * speed * Time.deltaTime);

        float hor = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, hor, 0) * rotateSpeed * Time.deltaTime);
    }
}
