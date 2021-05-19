using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombinationLimiter : MonoBehaviour
{
    public List<Button> PetButtons;
    public List<Button> CharacterButtons;

    public void SetAllInteractable()
    {
        foreach (Button b in PetButtons)
        {
            b.interactable = true;
        }
        foreach (Button b in CharacterButtons)
        {
            b.interactable = true;
        }
    }

    //public void 

    //Button PetButton = GameObject.Find("Pet1").GetComponent<Button>();
    //PetButton.interactable = false;

}
