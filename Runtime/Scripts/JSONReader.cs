using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;

public class JSONReader : MonoBehaviour
{
    public TextMeshPro jsonData;
    CarParts carParts;
 
    private void Start()
    {
        string packageFolderPath = "Packages/com.scivista.unity.hiringtest/Runtime/Resources/TestJSON.json";
        string jsonFilePath = Path.GetFullPath(packageFolderPath);
        string jsonString = File.ReadAllText(jsonFilePath);
        carParts = JsonUtility.FromJson<CarParts>(jsonString);
        StartCoroutine(LoopThroughCarInfo());
    }

    private IEnumerator LoopThroughCarInfo()
    { // Parse the JSON data into a C# object

        float timeInBetweenList = 1.5f;

        jsonData.text = "Car Parts: <br>Model: " + carParts.Engine.Model.ToString();
        yield return new WaitForSeconds(timeInBetweenList);
        jsonData.text = "Car Parts: <br>Horsepower: " + carParts.Engine.Horsepower.ToString();
        yield return new WaitForSeconds(timeInBetweenList);
        jsonData.text = "Wheels: <br>Type: " + carParts.Wheels[0].Type.ToString() + " Diameter Inches: " + carParts.Wheels[0].DiameterInches.ToString(); ;
        yield return new WaitForSeconds(timeInBetweenList);
        jsonData.text = "Wheels: <br>Type: " + carParts.Wheels[1].Type.ToString() + " Diameter Inches: " + carParts.Wheels[0].DiameterInches.ToString(); ;
        yield return new WaitForSeconds(timeInBetweenList);
        jsonData.text = "Wheels: <br>Type: " + carParts.Wheels[2].Type.ToString() + " Diameter Inches: " + carParts.Wheels[0].DiameterInches.ToString(); ;
        yield return new WaitForSeconds(timeInBetweenList);
        jsonData.text = "Wheels: <br>Type: " + carParts.Wheels[3].Type.ToString() + " Diameter Inches: " + carParts.Wheels[0].DiameterInches.ToString(); ;
        yield return new WaitForSeconds(timeInBetweenList);

        StartCoroutine(LoopThroughCarInfo());
    }


}

    [System.Serializable]
    public class CarParts
    {
        public Engine Engine;
        public Wheel[] Wheels;
    }

    [System.Serializable]
    public class Engine
    {
        public string Model;
        public int Horsepower;
    }

    [System.Serializable]
    public class Wheel
    {
        public string Type;
        public float DiameterInches;
    }
