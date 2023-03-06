using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{

    public int levelToUnlock = 1;
    public string nextLevel = "Question1";

    int lastCharacterInt;
    string lastCharacter;
 

    public void Continue()
    {
        lastCharacter = nextLevel.Remove(0, 8);
        lastCharacterInt = Convert.ToInt32(lastCharacter);
        if ( PlayerPrefs.GetInt("levelReached") <= lastCharacterInt) {
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
        SceneManager.LoadScene(nextLevel);
    }
    public void Menu()
    {
        lastCharacter = nextLevel.Remove(0, 8);
        lastCharacterInt = Convert.ToInt32(lastCharacter); ;
        if (PlayerPrefs.GetInt("levelReached") <= lastCharacterInt)
        {
            PlayerPrefs.SetInt("levelReached", levelToUnlock);
        }
        SceneManager.LoadScene("MainMenu");
    }
}
