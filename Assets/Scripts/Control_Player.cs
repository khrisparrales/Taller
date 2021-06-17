using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Control_Player : MonoBehaviour
{
   
   Rigidbody rb;
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
    }
    
    //ejecutar para decir que hara el objeto en cada fotograma con fisicas
    void FixedUpdate() {
        float movimiento_horizontal= Input.GetAxis("Horizontal");
        float movimiento_vertical = Input.GetAxis("Vertical");
        Vector3 movimiento= new Vector3(movimiento_horizontal,0.5f,movimiento_vertical);
        rb.AddForce(movimiento * fuerza );

    }
  
    
}
