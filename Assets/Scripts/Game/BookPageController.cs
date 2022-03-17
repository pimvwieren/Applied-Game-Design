using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BookPageController : MonoBehaviour
{
    private List<Transform> bookPages;
    private int currentPageIndex;

    public Button previousPageButton;
    public Button nextPageButton;

    private void Awake()
    {
        bookPages = GetComponentsInChildren<Transform>(true).Where(obj => obj.CompareTag("BookPage")).ToList();
    }

    private void Start()
    {
        ShowPage(0);
        AdjustPageNumbers();
    }

    private void AdjustPageNumbers()
    {
        List<TMP_Text> pageNoTexts = GetComponentsInChildren<TMP_Text>(true).Where(t => t.CompareTag("PageNumber")).ToList();
        for (int i = 0; i < pageNoTexts.Count; i++)
        {
            pageNoTexts[i].text = (1 + i).ToString();
        }
    }

    public void ShowFirstPage()
    {
        ShowPage(0);
    }

    public void ShowPreviousPage()
    {
        ShowPage(currentPageIndex - 1);
    }

    public void ShowNextPage()
    {
        ShowPage(currentPageIndex + 1);
    }

    private void ShowPage(int index)
    {
        currentPageIndex = Mathf.Clamp(index, 0, bookPages.Count);
        for (int i = 0; i < bookPages.Count; i++)
        {
            bookPages[i].gameObject.SetActive(i == index);
        }

        previousPageButton.interactable = currentPageIndex > 0;
        nextPageButton.interactable = currentPageIndex < bookPages.Count-1;
    }
}