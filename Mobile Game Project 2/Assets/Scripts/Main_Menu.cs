using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void LevelSelection(string levelname) { SceneManager.LoadScene(levelname); }

    public void QuitGame() { Application.Quit(); }

    public void ReloadScene() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }

  
}
