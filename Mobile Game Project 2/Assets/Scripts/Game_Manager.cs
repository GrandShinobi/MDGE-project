using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    //Handles points system, pause system and object spawning, death animations;
    Point_Coordinator scoring; //activate scoring script
    Trigger_Checkers trigger;
    
    public GameObject Player; //activate scoring script 

    // Start is called before the first frame update
    void Start()
    {
     scoring = GetComponent<Point_Coordinator>();  //initialse Point_Coordinator object
     trigger = Player.GetComponent<Trigger_Checkers>(); //initialse trigger object
     scoring.UpdateCoinsLeft(); //set grand total coins left
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.getPoint() == true)
        {
            scoring.updateScore();
            scoring.UpdateCoinsLeft();
            trigger.setPoint(false);
        }




    }
}
