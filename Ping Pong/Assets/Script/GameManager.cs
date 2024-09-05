using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontua�aoDoJogador1;
    public int pontua�aoDoJogador2;

    public Text textoDePontua�ao;
    private bool jogoEmpatado;

    void Start()
    {
        ReiniciarPartida();
    }

    void Update()
    {
       
        if (!jogoEmpatado && (pontua�aoDoJogador1 >= 7 || pontua�aoDoJogador2 >= 7))
        {
            FinalizarPartida();
        }

   
        if (pontua�aoDoJogador1 == 6 && pontua�aoDoJogador2 == 6 && !jogoEmpatado)
        {
            ResetaPara2Pontos();
        }

        
        if ((pontua�aoDoJogador1 == 4 && pontua�aoDoJogador2 == 0) || (pontua�aoDoJogador2 == 4 && pontua�aoDoJogador1 == 0))
        {
            ReiniciarPartida();
        }
    }

    public void AumentarPontua�aoDoJogador1()
    {
        pontua�aoDoJogador1 += 1;
        AtualizarTextoDePontua�ao();
    }

    public void AumentarPontua�aoDoJogador2()
    {
        pontua�aoDoJogador2 += 1;
        AtualizarTextoDePontua�ao();
    }

    public void AtualizarTextoDePontua�ao()
    {
        textoDePontua�ao.text = pontua�aoDoJogador1 + "X" + pontua�aoDoJogador2;
    }

    private void ReiniciarPartida()
    {
        pontua�aoDoJogador1 = 0;
        pontua�aoDoJogador2 = 0;
        jogoEmpatado = false;
        AtualizarTextoDePontua�ao();
    }

    private void ResetaPara2Pontos()
    {
        pontua�aoDoJogador1 = 0;
        pontua�aoDoJogador2 = 0;
        jogoEmpatado = true; 
        AtualizarTextoDePontua�ao();
    }

    private void FinalizarPartida()
    {
        Debug.Log("Partida finalizada! Vencedor: " + (pontua�aoDoJogador1 >= 7 ? "Jogador 1" : "Jogador 2"));
        ReiniciarPartida(); 
    }
}