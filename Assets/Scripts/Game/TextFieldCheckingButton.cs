using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class TextFieldCheckingButton : MonoBehaviour
{
    public TextField textField;
    public string correctAnswer;

    public UnityEvent OnCorrectAnswer;
    public UnityEvent OnIncorrectAnswer;

    public void ValidateSpell()
    {
        if (textField.text == correctAnswer)
        {
            OnCorrectAnswer.Invoke();
        }
        else
        {
            OnIncorrectAnswer.Invoke();
        }
    }
}
