using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsOnClick : MonoBehaviour
{
    public void GetInstructionMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
