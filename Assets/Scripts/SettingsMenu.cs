using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using System;

public class SettingsMenu : MonoBehaviour
{

    public GameObject restart;

    //public Text restartText;
    public GameObject restartTextUI;


    public void RestartButton()
    {
        restart.SetActive(true);
    }



    public void DeleteAllPlayerPrefs()
    {
        StartCoroutine(Wrong());
        PlayerPrefs.DeleteAll();
        restart.SetActive(false);
        
    }


    public void no()
    {
        restart.SetActive(false);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }




    public IEnumerator Wrong()
    {
        restartTextUI.SetActive(true);
        yield return new WaitForSeconds(1);
        restartTextUI.SetActive(false);
    }






}
