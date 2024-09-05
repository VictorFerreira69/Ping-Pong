using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontuaçaoDoJogador1;
    public int pontuaçaoDoJogador2;

    public Text textoDePontuaçao;
    private bool jogoEmpatado;

    void Start()
    {
        ReiniciarPartida();
    }

    void Update()
    {
       
        if (!jogoEmpatado && (pontuaçaoDoJogador1 >= 7 || pontuaçaoDoJogador2 >= 7))
        {
            FinalizarPartida();
        }

   
        if (pontuaçaoDoJogador1 == 6 && pontuaçaoDoJogador2 == 6 && !jogoEmpatado)
        {
            ResetaPara2Pontos();
        }

        
        if ((pontuaçaoDoJogador1 == 4 && pontuaçaoDoJogador2 == 0) || (pontuaçaoDoJogador2 == 4 && pontuaçaoDoJogador1 == 0))
        {
            ReiniciarPartida();
        }
    }

    public void AumentarPontuaçaoDoJogador1()
    {
        pontuaçaoDoJogador1 += 1;
        AtualizarTextoDePontuaçao();
    }

    public void AumentarPontuaçaoDoJogador2()
    {
        pontuaçaoDoJogador2 += 1;
        AtualizarTextoDePontuaçao();
    }

    public void AtualizarTextoDePontuaçao()
    {
        textoDePontuaçao.text = pontuaçaoDoJogador1 + "X" + pontuaçaoDoJogador2;
    }

    private void ReiniciarPartida()
    {
        pontuaçaoDoJogador1 = 0;
        pontuaçaoDoJogador2 = 0;
        jogoEmpatado = false;
        AtualizarTextoDePontuaçao();
    }

    private void ResetaPara2Pontos()
    {
        pontuaçaoDoJogador1 = 0;
        pontuaçaoDoJogador2 = 0;
        jogoEmpatado = true; 
        AtualizarTextoDePontuaçao();
    }

    private void FinalizarPartida()
    {
        Debug.Log("Partida finalizada! Vencedor: " + (pontuaçaoDoJogador1 >= 7 ? "Jogador 1" : "Jogador 2"));
        ReiniciarPartida(); 
    }
}