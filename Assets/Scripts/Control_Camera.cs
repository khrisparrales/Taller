using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Camera : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 posicionrelativa;
    // Start is called before the first frame update
    void Start()
    {
        posicionrelativa=transform.position- jugador.transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //LateUpdate se ejecuta despues de todos los updtes
    void LateUpdate() {
        transform.position=jugador.transform.position+posicionrelativa;
    }
}
