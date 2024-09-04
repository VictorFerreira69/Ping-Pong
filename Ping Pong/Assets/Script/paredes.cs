using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class paredes : MonoBehaviour
{
    public GameObject bola;
    public string cena;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == bola)
        {
            SceneManager.LoadScene(cena);
        }
    }
}
