using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode] 
public class Problems : MonoBehaviour
{
    
    void Awake()
    {
        InterestingController.sendSignal += UpdateNote;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateNote();
    }

    private void UpdateNote()
    {
       
        Debug.LogError("I'm Another Error, find out why I keep persisting and fix me! Hint: Just deleting me is not the solution");
    }
}

