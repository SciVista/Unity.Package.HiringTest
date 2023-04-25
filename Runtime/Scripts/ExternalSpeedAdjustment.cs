using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExternalSpeedAdjustment
{
    public static Action<float> speedAdjustment;
    // Start is called before the first frame update
    private static float speedChange;

    // Update is called once per frame
    public static void SpeedAdjustment()
    {
        speedChange = UnityEngine.Random.Range(-50.1f, 54.3f);
        speedAdjustment.Invoke(speedChange);
   
    }
 
}
