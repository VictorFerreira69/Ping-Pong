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
        if(golDoJogador1 == true)
        {
            FindObjectOfType<GameManager>().AumentarPontua�aoDoJogador2();
            other.gameObject.transform.position = Vector2.zero;
        }
        else
        {
            FindObjectOfType<GameManager>().AumentarPontua�aoDoJogador1();
            other.gameObject.transform.position = Vector2.zero;
        }
        
    }
}
