using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontuaçaoDoJogador1;

    public int pontuaçaoDoJogador2;

    public Text textoDePontuaçao;

    // Start is called before the first frame update
    void Start()
    {
        pontuaçaoDoJogador1 = 0;
        pontuaçaoDoJogador2 = 0;
        textoDePontuaçao.text = pontuaçaoDoJogador1 + "X" + pontuaçaoDoJogador2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void AumentarPontuaçaoDoJogador1()
    {
        pontuaçaoDoJogador1 += 1;
        AtulizarTextoDePontuaçao();
    }
   public void AumentarPontuaçaoDoJogador2()
    {
        pontuaçaoDoJogador2 += 1;
        AtulizarTextoDePontuaçao();
    }

    public void AtulizarTextoDePontuaçao()
    {
        textoDePontuaçao.text = pontuaçaoDoJogador1 + "X" + pontuaçaoDoJogador2;
    }
}
