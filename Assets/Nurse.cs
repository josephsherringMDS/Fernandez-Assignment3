using System.Diagnostics;
using UnityEngine;

public class Nurse : MonoBehaviour
{
    int nursePerformance;

    public void nurseDecorate()
    {
        UnityEngine.Debug.Log("Basic nurse decoration.");
    }

    public void sendToDoctor()
    {
        UnityEngine.Debug.Log("Sending to doctor.");
    }

    public void Start()
    {
        // Instantiate Nurse
        Nurse nurse = new GameObject("Nurse").AddComponent<Nurse>();

        // Call methods
        nurse.nurseDecorate();
        nurse.sendToDoctor();
    }
}