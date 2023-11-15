using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hospital : MonoBehaviour
{
    // Function to decorate the hospital
    public virtual void hospitalDecorator()
    {
        UnityEngine.Debug.Log("Basic hospital decoration.");
    }

    public virtual void trackCurrency()
    {
        UnityEngine.Debug.Log("Tracking currency.");
    }

    public virtual void trackDeaths()
    {
        UnityEngine.Debug.Log("Tracking deaths.");
    }

    public virtual void trackWaitingRoom()
    {
        UnityEngine.Debug.Log("Tracking waiting room.");
    }

    public void Start()
    {
        // Instantiate Hospital
        Hospital hospital = new GameObject("Hospital").AddComponent<Hospital>();

        // Call methods
        hospital.hospitalDecorator();
        hospital.trackCurrency();
        hospital.trackDeaths();
        hospital.trackWaitingRoom();
    }
}