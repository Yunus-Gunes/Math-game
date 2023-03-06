using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorMenu : MonoBehaviour
{
    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Red()
    {
        PlayerPrefs.SetString("renk", "red");
        ColorChange.renk = "red";
    }
    public void Blue()
    {
        PlayerPrefs.SetString("renk", "blue");
        ColorChange.renk = "blue";
    }
    public void Black()
    {
        PlayerPrefs.SetString("renk", "black");
        ColorChange.renk = "black";
    }
}
