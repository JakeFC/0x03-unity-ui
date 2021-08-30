using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
	public Button playButton;

	void Start ()
	{
		playButton.GetComponent<Button>().onClick.AddListener(PlayMaze);
	}
    public void PlayMaze()
	{
		SceneManager.LoadScene("Maze");
	}
}
