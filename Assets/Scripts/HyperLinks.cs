using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLinks : MonoBehaviour
{
    public void OpenPlayStoreApp()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.GameSun.MathGame");
    }

    public void OpenURL(string link)
    {
        Application.OpenURL(link);
    }
}
