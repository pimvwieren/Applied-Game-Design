using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterDrawing : MonoBehaviour
{
    public Sprite[] spriteVariants;
    public int currentSpriteIndex;
    public Image imageToDrawOn;
    
    private Image buttonImage;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
    }

    private void Start()
    {
        SetSprite(currentSpriteIndex);
    }

    private void SetSprite(int i)
    {
        currentSpriteIndex = i;
        imageToDrawOn.sprite = spriteVariants[currentSpriteIndex];
        buttonImage.sprite = spriteVariants[currentSpriteIndex];
    }

    public void ToggleSprites()
    {
        SetSprite((currentSpriteIndex + 1) % spriteVariants.Length);
    }
}
