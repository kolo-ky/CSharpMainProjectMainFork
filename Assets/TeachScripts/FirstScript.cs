using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int intVar = 1;
        float floatVar = 3.4f;
        string sringVar = "this is ";
        string sumStringVar = "sum = ";
        bool boolVar;

        Debug.Log(sringVar + intVar);
        Debug.Log(sringVar + floatVar);
        Debug.Log(sumStringVar + (floatVar + intVar));
    }
}
