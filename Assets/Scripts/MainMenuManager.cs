using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public void StartGame(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
     
    public void Options()
    {
        
    }
    
    public void Exit()
    {
        
    }
}
