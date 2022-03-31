using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// This is the abstract class every structure(city, roads, ... ) inherit behaviour from
/// </summary>
public class Structure : MonoBehaviour
{
    private int PosX;
    private int PosY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Methode for placing the structures at the map.
    /// Polymorphism applied here, because there are differences 
    /// in the positing of structures (cant place city on edge / 
    /// cant place road on node)
    /// </summary>
    /// <param name="center">The node to place the structure</param>
    public virtual void PlaceStructure(Node center)
    {
        throw new NotImplementedException();
    }


    public virtual void PlaceStructure(Edge edge)
    {
        throw new NotImplementedException();
    }
}
