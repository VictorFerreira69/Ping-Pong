using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MEnu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("jogo");
    }

    public void Sair()
    {
        Application.Quit();
    }
}
