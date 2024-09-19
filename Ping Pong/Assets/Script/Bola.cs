using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadeDaBola;
    public float fatorAumentoVelocidade = 2f;
    public Rigidbody2D oRigidbody2;

    public Transform pontoDeSaqueJogador1;
    public Transform pontoDeSaqueJogador2;

    private bool saqueJogador1 = true;
    private bool aguardandoSaque = true;

    public ControleDosJogadores jogador1;
    public ControleDosJogadores jogador2;

    private bool jogador1Encostou = false;
    private bool jogador2Encostou = false;

    private void Start()
    {
        PosicionarParaSaque();
    }

    private void Update()
    {
        if (aguardandoSaque)
        {
            oRigidbody2.velocity = Vector2.zero;
        }

        
        if (jogador1Encostou && Input.GetKeyDown(KeyCode.R) && !aguardandoSaque && saqueJogador1)
        {
            oRigidbody2.velocity = new Vector2(velocidadeDaBola * fatorAumentoVelocidade, 0);
        }

       
        if (jogador2Encostou && Input.GetKeyDown(KeyCode.RightControl) && !aguardandoSaque && !saqueJogador1)
        {
            oRigidbody2.velocity = new Vector2(-velocidadeDaBola * fatorAumentoVelocidade, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (aguardandoSaque && collisionInfo.gameObject.CompareTag("Jogador1"))
        {
            aguardandoSaque = false;
            MoverBola();
        }
        else if (!aguardandoSaque)
        {
            if (collisionInfo.gameObject.CompareTag("ParedeEsquerda"))
            {
                saqueJogador1 = false;
                PosicionarParaSaque();
            }
            else if (collisionInfo.gameObject.CompareTag("ParedeDireita"))
            {
                saqueJogador1 = true;
                PosicionarParaSaque();
            }

           
            if (collisionInfo.gameObject.CompareTag("Jogador1"))
            {
                jogador1Encostou = true;
            }

       
            if (collisionInfo.gameObject.CompareTag("Jogador2"))
            {
                jogador2Encostou = true;
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collisionInfo)
    {

        if (collisionInfo.gameObject.CompareTag("Jogador1"))
        {
            jogador1Encostou = false;
        }

        if (collisionInfo.gameObject.CompareTag("Jogador2"))
        {
            jogador2Encostou = false;
        }
    }

    private void MoverBola()
    {
        if (saqueJogador1)
        {
            oRigidbody2.velocity = new Vector2(velocidadeDaBola, 0);
        }
        else
        {
            oRigidbody2.velocity = new Vector2(-velocidadeDaBola, 0);
        }
    }

    private void PosicionarParaSaque()
    {
        aguardandoSaque = true;

        jogador1.ReiniciarPosicao();
        jogador2.ReiniciarPosicao();

        if (saqueJogador1)
        {
            transform.position = pontoDeSaqueJogador1.position;
        }
        else
        {
            transform.position = pontoDeSaqueJogador2.position;
        }

        oRigidbody2.velocity = Vector2.zero;
    }
}