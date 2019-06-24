using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    //Handles points system, pause system and object spawning, death animations;
    Point_Coordinator updateUI; //activate scoring script
    Trigger_Checkers trigger;
    
    public GameObject Player; //activate scoring script 
    public int powerUpduration; //set duration of power up
    private float timeleft = 0;
    // Start is called before the first frame update
    void Start()
    {
     updateUI = GetComponent<Point_Coordinator>();  //initialse Point_Coordinator object

     trigger = Player.GetComponent<Trigger_Checkers>(); //initialse trigger object
     

     updateUI.UpdateCoinsLeft(); //set grand total coins left
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.getPoint() == true)
        {
            updateUI.updateScore();
            updateUI.UpdateCoinsLeft();
            trigger.setPoint(false);
        }

        if (trigger.getPowerState() == true)
        {
           
            timeleft += Time.deltaTime;
            print("Time Left: " + timeleft);
            updateUI.UpdateTime( powerUpduration - timeleft);
            if (timeleft >= powerUpduration)
            {
                trigger.setPowerStat(false);
                timeleft = 0;
            }

        }
       



    }
}
