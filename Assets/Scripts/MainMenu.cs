using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void Play()
	{
		if ((PlayerPrefs.GetInt("levelReached")) <= 1)
		{
			SceneManager.LoadScene(PlayerPrefs.GetInt("levelReached") + 4);
		}
		else if ((PlayerPrefs.GetInt("levelReached")) > 39)
        {
			SceneManager.LoadScene(PlayerPrefs.GetInt("levelReached") + 2);
		}
		else
		{
			SceneManager.LoadScene(PlayerPrefs.GetInt("levelReached") + 3);
		}
	}
	public void Levels()
	{
		SceneManager.LoadScene(1);
	}
	public void Color()
	{
		SceneManager.LoadScene(2);
	}

	public void Settings()
	{
		SceneManager.LoadScene(3);
	}

	public void Quit()
	{
		Debug.Log("Exciting...");
		Application.Quit();
	}

}
