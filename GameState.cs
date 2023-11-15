using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameState : MonoBehaviour
{
    public void trackScore()
    {
        UnityEngine.Debug.Log("Tracking score.");
    }

    public void trackPatientsSaved()
    {
        UnityEngine.Debug.Log("Tracking patients saved.");
    }

    public void trackPatientsDied()
    {
        UnityEngine.Debug.Log("Tracking patients that have died.");
    }

    public void Start()
    {
        // Instantiate GameState
        GameState gameState = new GameObject("GameState").AddComponent<GameState>();

        // Call methods
        gameState.trackScore();
        gameState.trackPatientsSaved();
        gameState.trackPatientsDied();
    }
}