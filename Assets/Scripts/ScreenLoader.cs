using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour {

    public void NextSceenLoader()
    {
        int sceenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceenIndex + 1);
    }
	
    public void LoadStartSceen()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().ResetGame();
    }
    public void GameQuit()
    {
        Application.Quit();
    }

}
