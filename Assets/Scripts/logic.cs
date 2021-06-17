using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logic : MonoBehaviour
{
    int contador;
    Rigidbody rb;
    public Text puntuacion;
    public Text win;
    public float fuerza;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //awake inicializacion que usaremos oara ibtener referencias a otros componentes
    private void Awake() {
        rb=GetComponent<Rigidbody>();    
        contador=0;
        puntualizar();
        win.gameObject.SetActive(false);
    }
    
    //ejecutar para decir que hara el objeto en cada fotograma con fisicas
    void FixedUpdate() {
      

    }
    private void OnTriggerEnter(Collider other) {
        Destroy(other.gameObject);
        contador+=1;
        Debug.Log(contador);
        puntualizar();
        if (contador>=8)
        {
            win.gameObject.SetActive(true);
        }
    }
    void puntualizar(){
        puntuacion.text = "Puntuacion: "+contador;
    }
}
