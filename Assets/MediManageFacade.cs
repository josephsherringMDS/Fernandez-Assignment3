using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MediManageFacade : MonoBehaviour
{

    public void handleMenuActions()
        {
            UnityEngine.Debug.Log("Handling menu actions.");
        }

    // Function to handle actions related to nurses in the game
    public void handleNurseActions()
        {
            UnityEngine.Debug.Log("Handling nurse actions.");

        }

    // Function to track the overall game state
    public void trackGameState()
        {
            UnityEngine.Debug.Log("Tracking game state.");
        }

    // Function to track the status of the hospital in the game
    public void trackHospitalStatus()
        {
            UnityEngine.Debug.Log("Tracking hospital status.");
        }

    void Start()
    {
        // Instantiate MediManageFacade
        MediManageFacade mediManageFacade = new GameObject("MediManageFacade").AddComponent<MediManageFacade>();

        // Call methods
        mediManageFacade.handleMenuActions();
        mediManageFacade.handleNurseActions();
        mediManageFacade.trackGameState();
        mediManageFacade.trackHospitalStatus();
    }
}