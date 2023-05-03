using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using PathCreation;
using PathCreation.Examples;

public class LapCounting : MonoBehaviour
{
    public GameObject car;
    private Vector3 startPos;
    public TextMeshPro lapText;
    private int lapCount;

    // Start is called before the first frame update
    void Start()
    {
        PathFollower.startingPos += (value) => { startPos = value; };

        startPos = new Vector3(-4.3f, -.6f, .5f);
        lapText.text = "Lap Count: 0";
    }

    // Update is called once per frame
    void Update()
    {
        CheckLapCount();
    }

    void CheckLapCount()
    {
       float dist = Vector3.Distance(startPos, transform.position);
        float distThreshold = 0.1f;

        if (dist <= distThreshold)
            lapCount += 1;

        lapText.text = "Lap Count: " + lapCount.ToString();
    }

}
