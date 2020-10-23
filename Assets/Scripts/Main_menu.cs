using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public void StartAPP()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitAPP()
    {
        Application.Quit();  
    }

    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }
}
