using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class IncantationPanel : MonoBehaviour
{
    public TextField textField;
    private string correctAnswer;

    public UnityEvent OnCorrectAnswer;
    public UnityEvent OnIncorrectAnswer;

    public void ValidateSpell()
    {
        if (string.Equals(textField.text, correctAnswer, StringComparison.CurrentCultureIgnoreCase))
        {
            OnCorrectAnswer.Invoke();
        }
        else
        {
            OnIncorrectAnswer.Invoke();
        }
    }
    
    public void Query(string answer)
    {
        correctAnswer = answer;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
