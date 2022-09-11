using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackOnClick : MonoBehaviour
{
    public void BackToMenu(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
