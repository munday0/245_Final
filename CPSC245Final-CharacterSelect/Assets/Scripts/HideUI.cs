using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideUI : MonoBehaviour
{
    private CanvasGroup c;

    private void Start()
    {
        c = GetComponent<CanvasGroup>();
    }

    public void Hide()
    {
        c.alpha = 0f;
        c.blocksRaycasts = false;
        c.interactable = false;
    }

    public void Show()
    {
        c.alpha = 1f;
        c.blocksRaycasts = true;
        c.interactable = true;
    }
}
