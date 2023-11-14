using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ConcretePatientPrototype : MonoBehaviour
{
    // Class to represent a fictional ailment with symptoms
    public class FictionalAilment
    {
        public string Name { get; set; }
        public List<string> Symptoms { get; set; }
    }

    // The list of possible fictional ailments with symptoms
    List<FictionalAilment> ailments = new List<FictionalAilment>
    {
        new FictionalAilment
        {
            Name = "Chromatic Deprivation Disorder (CDD)",
            Symptoms = new List<string> { "Discomfort in monochromatic environments", "Disorientation", "Seeking color therapy" }
        },
        new FictionalAilment
        {
            Name = "Quantum Fatigue Syndrome (QFS)",
            Symptoms = new List<string> { "Persistent exhaustion", "Attributed to quantum fluctuations", "Regulating energy levels" }
        },
        new FictionalAilment
        {
            Name = "Temporal Navigation Impairment (TNI)"z
            Symptoms = new List<string> { "Struggle with time perception", "Difficulty navigating daily routines" }
        },
        new FictionalAilment
        {
            Name = "Auditory Sensory Avoidance (ASA)",
            Symptoms = new List<string> { "Perceiving own speech as excessively loud", "Social withdrawal", "Seeking sound desensitization" }
        },
        new FictionalAilment
        {
            Name = "Humidity-Induced Cognitive Impairment (HICI)",
            Symptoms = new List<string> { "Cognitive dysfunction in low humidity environments", "Seeking interventions for condition management" }
        },
        new FictionalAilment
        {
            Name = "Dream Integration Disorder (DID)",
            Symptoms = new List<string> { "Challenged to distinguish between dreams and reality", "Seeking therapeutic solutions for improved sleep quality" }
        },
        new FictionalAilment
        {
            Name = "Phantom Itch Syndrome (PIS)",
            Symptoms = new List<string> { "Sensation of itching in nonexistent areas", "Seeking medical help for relief" }
        },
        new FictionalAilment
        {
            Name = "Reverse Sensory Integration Syndrome (RSIS)",
            Symptoms = new List<string> { "Perceiving sensory stimuli in a reversed manner", "Seeking sensory integration therapies" }
        },
        new FictionalAilment
        {
            Name = "Cryptic Thought Syndrome (CTS)",
            Symptoms = new List<string> { "Belief that thoughts are encoded in a unique language", "Seeking psychiatric evaluation and cognitive therapies" }
        },
        new FictionalAilment
        {
            Name = "Prophetic Memory Disorder (PMD)",
            Symptoms = new List<string> { "Belief of experiencing future events", "Seeking medical attention for memory stabilization and cognitive reassurance" }
        },
    };

    // The type of emergency the patient has
    string emergencyType;

    // The severity level of the patient's condition
    int severity;

    // The time when the patient arrived
    float arrivalTime;

    // Function to create a clone of the patient prototype with a random fictional ailment and symptoms
    public ConcretePatientPrototype Clone()
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

        return clone;
    }
}
