using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class MenuUiHandler : MonoBehaviour
{
   
    public void StartNew()
    {
        // Load main scene if in menu
        SceneManager.LoadScene(1);
    }

    // ExitButton functionallity
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
