using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
[ExecuteInEditMode]
public class ThisIsAHeadache : MonoBehaviour
{

    public Problems problemScript;
 
    // Update is called once per frame
    void Update()
    {
      
        if(!problemScript.isActiveAndEnabled)
            Debug.LogError("Turning off the script is not fixing this bug!");

        Debug.LogError("Hello, I'm an error, find out why I keep persisting and fix me! Hint: Just deleting me is not the solution");
    }
 
}
