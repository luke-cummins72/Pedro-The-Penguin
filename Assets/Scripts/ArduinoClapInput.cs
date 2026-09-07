using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoController : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600); // replace with your port

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 50;
    }

    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                string message = sp.ReadLine();
                if (message.Contains("CLAP"))
                {
                    Debug.Log("Clap detected!");
                    // Trigger jump in your player script here
                    FindObjectOfType<PlayerMovement>().ForceJump();
                }
            }
            catch (System.TimeoutException)
            {
                // No data this frame, ignore
            }
        }
    }

    public void PlayerDied()
    {
        if (sp.IsOpen)
        {
            sp.Write("D");
            Debug.Log("Sent D to Arduino");
        }
        else
        {
            Debug.LogWarning("Serial port not open!");
        }
    }

    public void PlayerRespawn()
    {
        if (sp.IsOpen)
        {
            sp.Write("A");
        }
    }

    void OnApplicationQuit()
    {
        if (sp.IsOpen)
        {
            sp.Write("A");   // Reset LED to ambient mode
            sp.Close();
        }
    }
}
