using System.Collections;
using System.Collections.Generic;
using TMPro; //using text mesh pro because it is fancier
using UnityEngine.UI;
using UnityEngine;

public class Point_Coordinator : MonoBehaviour
{
    //This script works in tandem with game manager so send scoring to the UI and keep track of coins on the field

    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI coinsUI;
    private int score = 0;
    private int coins = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Updates the score for the score UI
public  void updateScore(int currentscore)
    {
        score = currentscore;
        scoreUI.text = "Score Left" + score.ToString();
    }
    //Update score by 1;
public  void updateScore()
    {
        score++;
        scoreUI.text = "Score Left: " + score.ToString();
    }

    //updates how many coins are left on the UI
public void UpdateCoinsLeft()
    {
      coins  = GameObject.FindGameObjectsWithTag("Coins").Length;

        coinsUI.text = "Coins Left: " + coins.ToString();
    }
}
