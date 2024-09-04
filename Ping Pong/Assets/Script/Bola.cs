using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadeDaBola;

    public float dire�aoAleatoriaX;
    public float dire�aoAleatoriaY;

    public Rigidbody2D oRigidbody2;
    // Start is called before the first frame update
    void Start()
    {
        MoverBola();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoverBola()
    {
        oRigidbody2.velocity = new Vector2(velocidadeDaBola,velocidadeDaBola);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        oRigidbody2.velocity += new Vector2(dire�aoAleatoriaX, dire�aoAleatoriaY);
    }
}
