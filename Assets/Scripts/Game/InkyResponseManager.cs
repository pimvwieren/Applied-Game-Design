using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InkyResponseManager : MonoBehaviour
{
    [HideInInspector] public BasicInkExample basicInkExample;

    public InputFieldPanel inputFieldPanel;
    public TMP_InputField inputField;
    public TMP_Text currentDialogText;

    public string[] validSpells;

    public List<InputQuery> inputResponses;
    [HideInInspector] public InputQuery activeInputQuery;

    private void Awake()
    {
        basicInkExample = GetComponent<BasicInkExample>();
    }

    public void SetActiveInputQuery(string currentDialog, int answerId)
    {
        inputFieldPanel.Show();
        
        currentDialogText.text = "\" " + currentDialog + " \"";
        inputField.text = "";
        activeInputQuery = inputResponses.First(r => r.id == answerId);
    }
    
    public void ValidateInput()
    {
        string input = inputField.text;
        inputFieldPanel.Hide();
        
        if (string.Equals(input, activeInputQuery.correctAnswer, StringComparison.CurrentCultureIgnoreCase))
        {
            TriggerResponse(activeInputQuery.onCorrectSpellResponse);
        }
        else
        {
            if (validSpells.Any(spell => string.Equals(input, spell, StringComparison.CurrentCultureIgnoreCase)))
            {
                TriggerResponse(activeInputQuery.onWrongSpellResponse);
            }
            else
            {
                TriggerResponse(activeInputQuery.onNonSpellResponse);
            }
        }
    }

    private void TriggerResponse(ResponseResult responseResult)
    {
        // TODO: Pim hier moet jij nog even de juiste inky methode aanroepen
        basicInkExample.TalkToNPC(responseResult.inkyDialogId);
        
        responseResult.OnResponseEvents.Invoke();
    }

    public void CancelInput()
    {
        inputFieldPanel.Hide();
    }
}

[Serializable]
public class InputQuery
{
    public int id;
    [TextArea] public string contextDescription;
    public string correctAnswer;
    
    [Header("Responses")]
    public ResponseResult onCorrectSpellResponse;
    public ResponseResult onWrongSpellResponse;
    public ResponseResult onNonSpellResponse;
}

[Serializable]
public class ResponseResult
{
    public string inkyDialogId;
    public UnityEvent OnResponseEvents;
}