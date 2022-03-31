using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main behaviour implementation for the settlements. This class inherites from 
/// Structure.cs
/// </summary>
public class Settlement : Structure
{
    // INHERITANCE from Structure
    public int PosX { get; private set; }
    public int PosY { get; private set; }

    // ENCAPSULATION for structure points
    private int m_StructureValue = 1;
    public int StructureValue
    {
        get { return m_StructureValue; }
        set
        {
            if (value < 0)
            {
                Debug.Log("You cant assign negative values to structures!");
            }
            else
            {
                m_StructureValue = value;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // override function
    // POLYMORPHISM
    public override void PlaceStructure(Node center)
    {


        // Logic for placing a settlement

        // eg. settlements must be seperated by 2 roads at least 
        base.PlaceStructure(center);
    }
}
