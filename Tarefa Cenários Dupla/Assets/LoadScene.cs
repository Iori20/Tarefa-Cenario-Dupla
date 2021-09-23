using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void CarregarCidade(){
        SceneManager.LoadScene("SampleScene");
    }
    public void Sair()
    {
        Application.Quit();
    }
}
