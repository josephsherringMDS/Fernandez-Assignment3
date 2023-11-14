using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class HospitalDecorator : MonoBehaviour
{
    protected Hospital hospital; // Reference to the base Hospital component

    public void SetHospital(Hospital baseHospital)
    {
        this.hospital = baseHospital;
    }

    public virtual void hospitalDecorator()
    {
        if (hospital != null)
        {
            hospital.hospitalDecorator(); // Delegate to the base Hospital component
        }
    }

    // Function to track upgrades in the hospital
    public virtual void trackUpgrades()
    {
        UnityEngine.Debug.Log("Tracking upgrades in the hospital.");
    }
}

public class ConcreteHospitalDecorator : HospitalDecorator
{

    public override void hospitalDecorator()
    {
        base.hospitalDecorator();

        UnityEngine.Debug.Log("Enhanced hospital decoration.");
    }
}
