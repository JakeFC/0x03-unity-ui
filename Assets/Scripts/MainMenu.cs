using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public Button playButton;
	public Button quitButton;

	void Start ()
	{
		playButton.GetComponent<Button>().onClick.AddListener(PlayMaze);
		quitButton.GetComponent<Button>().onClick.AddListener(QuitMaze);
	}

    public void PlayMaze()
	{
		SceneManager.LoadScene("Maze");
	}

	public void QuitMaze()
	{
		Debug.Log("Quit Game");
		Application.Quit();
	}
}
