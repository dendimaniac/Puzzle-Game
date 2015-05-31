using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	private GameObject pauseMenu;
	private GameObject victoryMenu;
	private bool isPaused = false;

	[HideInInspector]
	public static bool hasWon = false;
	
	void Start () {
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		pauseMenu = GameObject.Find ("Pause Menu");
		victoryMenu = GameObject.Find ("Victory Menu");
		hasWon = false;
		Time.timeScale = 1;
	}

	void Update () {
		if (Input.GetButtonDown("Cancel"))
		{
			if (!isPaused && !hasWon)
			{
				PauseGame();
			}
			else if (isPaused)
			{
				ResumeGame();
			}
		}

		if (hasWon)
		{
			Time.timeScale = 0;
			victoryMenu.transform.localPosition = new Vector2(0f,0f);
		}
	}

	void PauseGame ()
	{
		isPaused = true;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		Time.timeScale = 0;
		pauseMenu.transform.localPosition = new Vector2(0f,0f);
	}

	public void ResumeGame ()
	{
		isPaused = false;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
		Time.timeScale = 1;
		pauseMenu.transform.localPosition = new Vector2(0f,600f);
	}

	public void ExitGame()
	{
			Application.Quit ();
	}

	public void LoadNextLevel()
	{
			Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void BackToMenu()
	{
			Application.LoadLevel ("Menu");
	}

	public void Retry()
	{
			Application.LoadLevel (Application.loadedLevel);
	}
}