using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Checkers : MonoBehaviour
{
   private GameObject player; //get player objects

   
    int point =0; //number of coins picked up.
    bool isPoint = false;
    bool power_up; //
    // Start is called before the first frame update


    void Start()
    {
        player = GetComponent<PlayerMaster>().player; //get player object by making refrence to player master
    }


    void OnTriggerEnter(Collider collider)
    {

        if (collider.gameObject.CompareTag("Enemy")) //when player touches enemy, dies by SetActive false for now. 
        {
            player.gameObject.SetActive(false);
            

        }
        if (collider.gameObject.CompareTag("Coins")) //when player touches coins gain a point;
        {

            collider.gameObject.SetActive(false);
            point++;

            isPoint = true;
        }

    }

    public bool getPoint() //check if player has gotten a coin
    {
        return isPoint;
    }
    public void setPoint(bool isPoint) //set point
    {
        this.isPoint = isPoint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
