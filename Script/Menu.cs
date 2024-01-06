using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
        sise.can = 5;
        Time.timeScale = 1.0f;
        kutu_hareketi.puan = 0;
    
    }

    public void menu()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
   public void GameExit()
    {
        Application.Quit();
    }
}
