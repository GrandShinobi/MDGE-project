using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
   void OnTriggerEnter( Collider collider)
    {
        print("object collided");
        if (collider.gameObject.tag == "Enemy")
        {
            print("object collided");
            this.gameObject.SetActive(false);
        }
    }
}
