using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadeDaBola;

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
}
