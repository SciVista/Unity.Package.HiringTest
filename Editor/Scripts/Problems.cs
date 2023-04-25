using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteInEditMode] 
public class Problems : MonoBehaviour
{
     public ThisIsAHeadache headacheScript;
    void Awake()
    {
        InterestingController.sendSignal += UpdateNote;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateNote();


        if (!headacheScript.isActiveAndEnabled)
            Debug.LogError("Turning off the script is not fixing this bug!");
    }

    private void UpdateNote()
    {
       
        Debug.LogError("I'm Another Error, find out why I keep persisting and fix me! Hint: Just deleting me is not the solution");
    }
}

