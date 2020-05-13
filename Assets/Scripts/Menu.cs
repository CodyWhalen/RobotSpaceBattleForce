using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("Start");    
    }
    public void Howto()
    {
        SceneManager.LoadScene("HowTo");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Quit()
    {
        Quit();
    }
    public void Level1()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Tutoral()
    {
        SceneManager.LoadScene("Tutoral");
    }
}
