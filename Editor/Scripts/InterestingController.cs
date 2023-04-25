using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class InterestingController : MonoBehaviour
{
    public static Action sendSignal; 

    // Update is called once per frame
    void Update()
    {
        sendSignal.Invoke();
    }
}
