using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroScope : MonoBehaviour
{
    private bool gyroEnabled;
    private Gyroscope gyro;
    // Start is called before the first frame update
    void Start()
    {
        gyroEnabled = EnableGyro(); //enables gyroscope on phone
    }


    private bool EnableGyro() //this is to ensure gyro is turned on before gameplay.
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {
        float rotX = gyro.attitude.x; //get X rotation values,  this tills table left and right.
        float rotY = gyro.attitude.y; //get y rotation values,  this rotates table clockwise and anticlockwise .
        float rotZ = gyro.attitude.z; //get Z rotation values,  this tills table forward and backwards

        float rotationX = Mathf.Clamp(rotX, -45.0f, 45.0f);
        float rotationZ = Mathf.Clamp(rotZ, 0.05f, 0.05f);
      //  print("rotation of x power" + gyro.attitude.x);
        print("rotation of z " + gyro.attitude.z);
        if ((int)this.transform.rotation.eulerAngles.x == 45f)
        {
            rotX -= 0.5f;
        }
        if (345 == (int)this.transform.rotation.eulerAngles.x)
        {
            rotX += 0.5f;
        }
        /*  if ((int)this.transform.rotation.eulerAngles.z == 45f)
          {
              rotZ -= 0.5f;
          }
          if (345 == (int)this.transform.rotation.eulerAngles.z)
          {
              rotZ += 0.5f;
          }


           if(this.transform.rotation.eulerAngles.x >= 45f )
           {
               rotX = 0;
           }
           if (this.transform.rotation.eulerAngles.x <= 365-45f)
               {
                   rotX = 0;
               }
               */

        //print("Statement is " + (365-45f <=this.transform.rotation.eulerAngles.x   || this.transform.rotation.eulerAngles.x >= 45f));
       // transform.Rotate(0, 0, rotationZ);

      //Quaternion finalrotation  =  Quaternion.Slerp(0, 0, rotationZ); // we dw rotation so only up and down

        //transform.localRotation = finalrotation;
       
    }
}
