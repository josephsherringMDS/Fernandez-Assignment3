using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Function to display the menu
    public void displayMenu()
    {
        UnityEngine.Debug.Log("Displaying the menu.");
    }

    // Function to handle user input for the menu
    public void handleInput()
    {
        UnityEngine.Debug.Log("Handling user input for the menu.");
    }

    // Function to display instructions in the menu
    public void displayInstructions()
    {
        UnityEngine.Debug.Log("Displaying instructions in the menu.");
    }

    public void Start()
    {
        // Instantiate Menu
        Menu menu = new GameObject("Menu").AddComponent<Menu>();

        // Call methods
        menu.displayMenu();
        menu.handleInput();
        menu.displayInstructions();
    }
}