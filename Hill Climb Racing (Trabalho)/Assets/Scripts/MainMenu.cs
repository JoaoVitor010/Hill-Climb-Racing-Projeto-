using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(2);
        
    }

    public void LoadGame1()
    {
        SceneManager.LoadScene(3); 
    } 
}
