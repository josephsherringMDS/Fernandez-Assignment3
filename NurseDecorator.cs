using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public abstract class NurseDecorator : MonoBehaviour
{
    protected Nurse nurse; // Reference to the base Nurse component

    public virtual void nurseDecorate()
    {
        if (nurse != null)
        {
            nurse.nurseDecorate(); // Delegate to the base Nurse component
        }
    }

    // Function to allocate urgency order
    public virtual void allocateUrgencyOrder()
    {
        UnityEngine.Debug.Log("Allocating urgency order.");
    }

    // Function to track nurse performance
    public virtual void trackNursePerformance()
    {
        UnityEngine.Debug.Log("Tracking nurse performance.");
    }

    // Function to track upgrades
    public virtual void trackUpgrades()
    {
        UnityEngine.Debug.Log("Tracking upgrades.");
    }
}

public class ConcreteNurseDecorator : NurseDecorator

    public override void allocateUrgencyOrder()
{
    base.allocateUrgencyOrder();
    UnityEngine.Debug.Log("Enhanced urgency order allocation.");
}

public void Start()
{
    // Instantiate NurseDecorator
    NurseDecorator nurseDecorator = new GameObject("NurseDecorator").AddComponent<NurseDecorator>();

    // Call methods
    nurseDecorator.nurseDecorate();
    nurseDecorator.allocateUrgencyOrder();
    nurseDecorator.trackNursePerformance();
    nurseDecorator.trackUpgrades();
}
}