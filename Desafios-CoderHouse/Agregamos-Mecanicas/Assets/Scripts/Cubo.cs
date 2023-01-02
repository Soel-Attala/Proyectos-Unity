using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public int Health = 100;
    private int velocidad = 2;
    private float direccion;

    
    

    // Start is called before the first frame update
    void Start()
    {
     Instrucciones();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        MovimientoJugador();

        if (Input.GetKeyDown(KeyCode.R))
        Damage();

        Death();

        if(Input.GetKeyDown(KeyCode.E))
        Heal();
        
        Invencible();

        if(Input.GetKeyDown(KeyCode.Q))
        Speed();
        
        if(Input.GetKeyDown(KeyCode.A))
        Direccion();

        
        
    }

    void MovimientoJugador()
    {
        transform.position += new Vector3(1,0,0);
    }

    void Damage()
    {
        Health = Health - 25;
    }

    void Heal()
    {
        Health = Health + 10;
    }

    public void Death()
    {
        if (Health <= 0) Destroy(gameObject);
    }

    public void Invencible()
    {
        if (Health == 150)
        GetComponent<Renderer>().material.color = Color. blue;
    }

    void Speed ()
    {
        transform.position += new Vector3(5,0,0);
    }

    void Direccion()
    {
        transform.position += new Vector3(-3,0,0);
    }

    void Instrucciones ()
    {
        Debug.Log ("Presiona E para aumentar tu vida en 10");
        Debug.Log ("Presiona R para reducir tu vida en 25");
        Debug.Log ("Presiona D para moverte en 1 hacia la derecha");
        Debug.Log ("Presiona A para moverte en 3 hacia la izquierda");
        Debug.Log ("Presiona Q para moverte en 5 hacia la derecha");
        Debug.Log ("en caso de superar los 150 de vida entras en modo invencible el cubo se vuelve azul");
    }

    
}
