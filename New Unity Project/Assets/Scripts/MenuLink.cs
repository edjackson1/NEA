using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLink : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadSceneAsync("Game 1");
	}

	public void MenuGame()
	{
		SceneManager.LoadSceneAsync("Menu");
	}

	public void SettingsGame()
	{
		SceneManager.LoadSceneAsync("Settings");
	}
	
	public void QuitGame()
	{
		Application.Quit();
	}


}


