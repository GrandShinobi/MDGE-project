using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class Setting_Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool isgyro = true;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Master Volume", volume);
    }

    public void EnableGyro(bool gyro)
    {
        isgyro = gyro;
    }

    public bool getGyro()
    {
        return isgyro;
    }
}
