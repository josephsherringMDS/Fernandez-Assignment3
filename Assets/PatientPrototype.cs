using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; // Import Unity's Random class to avoid conflicts
 
public class PatientPrototype : ConcretePatientPrototype
{
    // Randomly select a fictional ailment from the list
    FictionalAilment randomAilment; // Moved the declaration inside a method

    public void ClonePrototype()
    {
        randomAilment = ailments[Random.Range(0, ailments.Count)];

        // Log the selected ailment and symptoms
        UnityEngine.Debug.Log($"Cloning patient prototype with fictional ailment: {randomAilment.Name}, Symptoms: {string.Join(", ", randomAilment.Symptoms)}");

        // Create a new instance of PatientPrototype and copy the values
        PatientPrototype clone = new PatientPrototype();
        clone.emergencyType = randomAilment.Name;
        clone.arrivalTime = this.arrivalTime;
    }
}