﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOnClick : MonoBehaviour
{
    public void PlayLevel(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}
