using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ABSTRACTION 
    // Methode to handle one Turn

    public void HandleTurn()
    {
        // First check if number assigned showed up on dice
        CheckDice();

        // Second, check all nodes for settlements/ Citys
        CheckStructures();

        // Third, resource gathering
        SubmitResourcesToPlayers();

        // Forth, update buildings after possible upgrades
        UpdateBuildings();
    }



    public int CheckDice()
    {
        return 8;
    }

    public List<Structure> CheckStructures()
    {
        List<Structure> buildings = new List<Structure>();

        return buildings;
    }

    public void SubmitResourcesToPlayers()
    {

    }

    public void UpdateBuildings()
    {

    }
}
