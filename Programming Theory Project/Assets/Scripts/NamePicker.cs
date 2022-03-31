using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamePicker : MonoBehaviour
{
    // Read the entered playername
    public void ReadStringInput(string s)
    {
        MenuManager.Instance.Name = s;
    }
}
