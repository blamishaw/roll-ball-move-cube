using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ExitOnClick : MonoBehaviour
{
    public void Quit()
    {
        EditorApplication.isPlaying = false;
    }
}
