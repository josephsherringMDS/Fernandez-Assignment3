using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Hospital : MonoBehaviour
{
    // Function to decorate the hospital
    public virtual void hospitalDecorator()
    {
        Debug.Log("Basic hospital decoration.");
    }
}
