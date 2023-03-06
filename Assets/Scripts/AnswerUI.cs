using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class AnswerUI : MonoBehaviour
{
    public Text answerText;


    void Update()
    {
        try
        {
            answerText.text = Game.userAnswer.ToString();
        }
        catch (NullReferenceException)
        {
            
        }
    }
}
