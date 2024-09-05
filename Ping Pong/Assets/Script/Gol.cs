using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golDoJogador1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager gameManager = FindObjectOfType<GameManager>();

        if (golDoJogador1)
        {
            gameManager.AumentarPontua�aoDoJogador2();
        }
        else
        {
            gameManager.AumentarPontua�aoDoJogador1();
        }

        other.gameObject.transform.position = Vector2.zero;
    }
}
