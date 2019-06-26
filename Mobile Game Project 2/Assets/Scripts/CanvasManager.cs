using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{//This canvas creates a simpleton which guides canvas through all scenes
    private static CanvasManager Instance;

    public GameObject pauseMenuUI;
    public GameObject pauseButtonUI;
    public GameObject mainMenuUI;
    
    public GameObject gameOverUI;

    string HelloWorld;

    private int level = 0;
    private int controlSelect; //what control options did the player use?

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            print("Instance set");
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    public void UpdateLevelChange(int level)
    {
        if (level != 0)
        {
            mainMenuUI.SetActive(false);
            pauseButtonUI.SetActive(true);
           
        }
        else
        {
            mainMenuUI.SetActive(true);
            pauseButtonUI.SetActive(false);
           
            pauseMenuUI.SetActive(false);
        }

    }

    public void OPTIONSUpdateLevelChange() //New 1 use this one, use on buttons that will change scenes only! And must use it!

    {
        //Note: Turning off option page is already set in Option buttion using Unity setactive.
        if (SceneManager.GetActiveScene().name == "Start Menu" && mainMenuUI.activeSelf == false) //in menu and menuPage is turned off
        {

            mainMenuUI.SetActive(true); //turn on menu page and turn off option page

        }

        if (SceneManager.GetActiveScene().name != "Start Menu" && pauseMenuUI.activeSelf == false) //in level and pause page is turned off, we want to set opposite
        {
            pauseMenuUI.SetActive(true); //same as above logic

        }
    }

    public  void setGameOverScreen()
    {
        gameOverUI.SetActive(true);
    }

    public void updateSelectedControls(int selection )
    {
        print("selected control is " + selection);
        controlSelect = selection;
    }

    public int checkSelectedControls()
    {
        return controlSelect;
    }

   
    public void LevelSelection(string levelname) { SceneManager.LoadScene(levelname); }

    public void QuitGame() { Application.Quit(); }

    public void ReloadScene() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); pauseMenuUI.SetActive(false); }
    /*-----------------------------Rmb to use active scenes to check for loaded scene in next code revision
     *  Current build, uses a in class integer to keep track of scene change which will not be very good when there
     *  are multiple methods to switch scenes that are not all functioning in the class.
     *  Rmb to add exception to not only main menu but also selection screen. 
     *  Yay.
     * -----------------------------------*/
}
