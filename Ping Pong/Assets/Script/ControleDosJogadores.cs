using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDosJogadores : MonoBehaviour
{
    private float vertical;
    Rigidbody2D rigidbody2;
    public bool Jogador1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        rigidbody2.velocity = new Vector2(rigidbody2.velocity.x, vertical * speed);
        
    }

   private void MoverJogador1()
    {
       
    }
}
