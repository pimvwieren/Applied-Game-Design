using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterDrawing : MonoBehaviour
{
    public Sprite[] spriteVariants;
    public Image imageToDrawOn;
    
    private int currentSpriteIndex;

    private void Start()
    {
        SetSprite(0);
    }

    private void SetSprite(int i)
    {
        currentSpriteIndex = i;
        imageToDrawOn.sprite = spriteVariants[currentSpriteIndex];
    }

    public void ToggleSprites()
    {
        SetSprite((currentSpriteIndex + 1) % spriteVariants.Length);
    }
}
