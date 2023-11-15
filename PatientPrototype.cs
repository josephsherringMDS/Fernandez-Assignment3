using UnityEngine;

public class PatientPrototype : ConcretePatientPrototype
{
    // This class inherits from ConcretePatientPrototype, so you don't need to redefine ailments, emergencyType, severity, and arrivalTime.

    // Function to create a clone of the patient prototype with a random fictional ailment and symptoms
    public new PatientPrototype Clone()
    {
        // Randomly select a fictional ailment from the list
        FictionalAilment randomAilment = ailments[Random.Range(0, ailments.Count)];

        // Log the selected ailment and symptoms
        UnityEngine.Debug.Log($"Cloning patient prototype with fictional ailment: {randomAilment.Name}, Symptoms: {string.Join(", ", randomAilment.Symptoms)}");

        // Create a new instance of PatientPrototype and copy the values
        PatientPrototype clone = new PatientPrototype();
        clone.emergencyType = randomAilment.Name;
        clone.severity = this.severity;
        clone.arrivalTime = this.arrivalTime;
        return clone;
    }

    new void Start()
    {
        // Instantiate PatientPrototype
        PatientPrototype patientPrototype = new GameObject("PatientPrototype").AddComponent<PatientPrototype>();

        // Call methods
        patientPrototype.Clone();
        patientPrototype.UrgencyTimer();
        patientPrototype.StoreSymptoms();
        patientPrototype.StoreAilments();
    }
}
