using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Doctor : MonoBehaviour
{
    // The specialty of the doctor
    string specialty;

    // The effectiveness of the doctor's treatment
    int treatmentEffectiveness;

    // Function to treat a patient's ailment
    public void treatAilment(PatientPrototype patient)
    {
        string patientAilment = patient.emergencyType;
        UnityEngine.Debug.Log($"Treating ailment: {patientAilment}.");
    }

    public void Start()
    {
        // Instantiate Doctor
        Doctor doctor = new GameObject("Doctor").AddComponent<Doctor>();

        // Call methods
        doctor.treatAilment();
    }
}