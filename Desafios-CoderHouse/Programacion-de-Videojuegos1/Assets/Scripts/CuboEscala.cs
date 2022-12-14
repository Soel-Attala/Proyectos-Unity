using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboEscala : MonoBehaviour
{
    public Vector3 nuevaEscala = new Vector3(0.02f,0.02f,0.02f);

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update() 
    {
        EscalaJugador();
    }

    void EscalaJugador()
    {
        transform.localScale += nuevaEscala;
    }
}
