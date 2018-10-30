using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    public void SwitchScene(int newScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(newScene);
    }
	
	//NOTE: doesn't work in editor
	public void Quit() {
        Application.Quit();
	}
}
