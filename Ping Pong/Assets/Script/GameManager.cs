using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pontua�aoDoJogador1;

    public int pontua�aoDoJogador2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public  void AumentarPontua�aoDoJogador1()
    {
        pontua�aoDoJogador1 += 1;
    }
   public void AumentarPontua�aoDoJogador2()
    {
        pontua�aoDoJogador2 += 1;
    }
}
