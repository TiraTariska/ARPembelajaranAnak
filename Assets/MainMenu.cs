using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TombolKeluar()
    {
        Application.Quit();
        Debug.Log("Game Close");
    }

    public void MainkanAR()
    {
        SceneManager.LoadScene("MainkanAR");
    }

    public void Informasi()
    {
        SceneManager.LoadScene("Informasi");
    }

    public void Kredit()
    {
        SceneManager.LoadScene("Kredit");
    }
}
