using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLink : MonoBehaviour
{
	public void PlayGame() //enables you to make the button interactable / lead you places
	{
		SceneManager.LoadSceneAsync("Game 1");//loads the game for the player
	}

	public void MenuGame() //enables you to make the button interactable / lead you places
	{
		SceneManager.LoadSceneAsync("Menu"); //loads the menu scene for the player
	}

	public void SettingsGame() //enables you to make the button interactable / lead you places
	{
		SceneManager.LoadSceneAsync("Settings"); //loads the settings scene for the player
	}

	public void EndScreen() //enables you to make the button interactable / lead you places
	{
		SceneManager.LoadSceneAsync("EndScreen"); //loads the end screen
	}

	public void TutorialScreen() //enables you to make the button interactable / lead you places
	{
		SceneManager.LoadSceneAsync("Tutorial"); //loads the tutorial screen
	}
	
	public void QuitGame() //enables you to make the button interactable / lead you places
	{
		Application.Quit();
		Debug.Log("Quit Game"); //shows a message in the console that the game has been shut down
	}


}


