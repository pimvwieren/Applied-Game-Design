using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BookOverlay : Overlay
{
    private BookPageController bookPageController;
    
    protected override void Awake()
    {
        base.Awake();
        bookPageController = GetComponentInChildren<BookPageController>();
    }
    
    public override void ShowOverlay()
    {
        base.ShowOverlay();
    }
}
