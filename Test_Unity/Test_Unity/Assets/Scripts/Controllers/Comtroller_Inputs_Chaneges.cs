using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Comtroller_Inputs_Chaneges : MonoBehaviour
{
    public BoxGenerator boxGenerator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void IsChangeTime(string value)
    {
        boxGenerator.TimeCreateNewCube = Convert.ToSingle(value);
    }
    public void IsChangeSpeed(string value)
    {
        boxGenerator.Speed = Convert.ToSingle(value);
    }
    public void IsChangeDistance(string value)
    {
        boxGenerator.Distance = Convert.ToSingle(value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
