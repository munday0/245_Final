using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Stephanie Munday, Isa Lee
 * ID: 2343625, 2343486
 * smunday@chapman.edu, isalee@chapman.edu
 * CPSC 245-01
 * Final - Character Select
 *
 * HideUI script - accounts for hiding UI canvas groups
 */

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
