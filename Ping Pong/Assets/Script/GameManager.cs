using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int pontua�aoDoJogador1;

    public int pontua�aoDoJogador2;

    public Text textoDePontua�ao;

    // Start is called before the first frame update
    void Start()
    {
        pontua�aoDoJogador1 = 0;
        pontua�aoDoJogador2 = 0;
        textoDePontua�ao.text = pontua�aoDoJogador1 + "X" + pontua�aoDoJogador2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void AumentarPontua�aoDoJogador1()
    {
        pontua�aoDoJogador1 += 1;
        AtulizarTextoDePontua�ao();
    }
   public void AumentarPontua�aoDoJogador2()
    {
        pontua�aoDoJogador2 += 1;
        AtulizarTextoDePontua�ao();
    }

    public void AtulizarTextoDePontua�ao()
    {
        textoDePontua�ao.text = pontua�aoDoJogador1 + "X" + pontua�aoDoJogador2;
    }
}
