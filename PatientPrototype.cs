using System;
using UnityEngine;

public class PatientPrototype : ConcretePatientPrototype
{
    // Randomly select a fictional ailment from the list
    FictionalAilment randomAilment = ailments[Random.Range(0, ailments.Count)];

    // Log the selected ailment and symptoms
    Debug.Log($"Cloning patient prototype with fictional ailment: {randomAilment.Name}, Symptoms: {string.Join(", ", randomAilment.Symptoms)}");

        // Create a new instance of PatientPrototype and copy the values
        PatientPrototype clone = new PatientPrototype();
        clone.emergencyType = randomAilment.Name;
        clone.severity = this.severity;
        clone.arrivalTime = this.arrivalTime;
}
