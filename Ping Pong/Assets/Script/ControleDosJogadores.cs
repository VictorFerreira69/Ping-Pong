using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ControleDosJogadores : MonoBehaviour
{
    public float velocidadeDoJogador;
    public bool Jogador1;
    public float yMinimo;
    public float yMaximo;

    public Vector2 posicaoInicialJogador1;
    public Vector2 posicaoInicialJogador2; 

    private void Start()
    {
        
        ReiniciarPosicao();
    }

    private void Update()
    {
        if (Jogador1)
        {
            MoverJogador1();
        }
        else
        {
            MoverJogador2();
        }
    }

    private void MoverJogador1()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }

    private void MoverJogador2()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMinimo, yMaximo));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * velocidadeDoJogador * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * velocidadeDoJogador * Time.deltaTime);
        }
    }

    public void ReiniciarPosicao()
    {
        
        if (Jogador1)
        {
            transform.position = posicaoInicialJogador1;
        }
        else
        {
            transform.position = posicaoInicialJogador2;
        }
    }
}
