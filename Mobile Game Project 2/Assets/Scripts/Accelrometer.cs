using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accelrometer : MonoBehaviour
{
    public bool isFlat = true;
    private Rigidbody rigid; //for the object rigidbody
    public int speed =5;
    public float tiltSpeedLimit = 0.8f;
    public float tiltLimit = 2;
    public float tiltSpeed = 5;

   

    //Setting gyro 
    private GameObject Setting;
    public Setting_Menu isgyro;
    // Start is called before the first frame update
    void Start()
    {
        if (isgyro.getGyro() == true)
        {
            print("Gyro is " + isgyro.getGyro());
            rigid = GetComponent<Rigidbody>(); //for ball
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UseAcclerometer(); //using acclerometer to tilt table

    }

    public void UseAcclerometer()
    {
        Vector3 tilt_force = Input.acceleration * speed; //using accleration input to measure tiltness in terms of tilt_force


        float tiltX = Mathf.Clamp(tilt_force.x, -tiltSpeedLimit, tiltSpeedLimit); //limits the max tiltspeed in x coordinates;
        float tiltY = Mathf.Clamp(tilt_force.y, -tiltSpeedLimit, tiltSpeedLimit); //limits the max tiltspeed in y coordinates;

       // Debug.Log("Current Power " + transform.rotation.x * tiltSpeed);
       /* if ( transform.rotation.x >= tiltLimit )
        {
            tiltX= 0;
        }
        if (transform.rotation.y >= tiltLimit)
        {
            tiltY= 0;
        }*/
        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltX, 0, tiltY);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target,  tiltSpeed  );
        // rigid.AddForce(tiltX * speed, 0,tiltY *speed); //at vector3 in terms of x y axis. because we dw up and down movement of the phone to affect coordinates, hence no z.
        // transform.Rotate(tiltX, 0, tiltY);

    }
}
