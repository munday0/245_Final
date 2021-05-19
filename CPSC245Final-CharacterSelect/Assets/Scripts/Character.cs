using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
 * Stephanie Munday, Isa Lee
 * ID: 2343625, 2343486
 * smunday@chapman.edu, isalee@chapman.edu
 * CPSC 245-01
 * Final - Character Select
 *
 * Character script - accounts for switching between characters
 */

// make sure selected one is interactable

public class Character : MonoBehaviour
{
    public GameObject[] Characters = new GameObject[24]; //list of different character objects to be chosen from
    public List<Button> PetButtons;

    public SelectionTracker s;
    private Pet petToSet;

    public int CharaIndex = 0; //index of character object
    private int currIndex;

    private void Start()
    {
        s = GameObject.Find("PetPanel").GetComponent<SelectionTracker>();
    }

    // Alternates between character skins
    public void SwitchCharacter()
    {
        ClearModels();
        if (CharaIndex % 2 == 0)
        {
            CharaIndex = (currIndex + 1) % Characters.Length;
        }
        else
        {
            CharaIndex = (currIndex) % Characters.Length;
        }
        Characters[CharaIndex].SetActive(true);
    }

    // Clear visible characters 
    public void ClearModels()
    {
        for (int i = 0; i < Characters.Length; ++i)
        {
            Characters[i].SetActive(false);
        }
    }

    public void ResetInteractable()
    {
        foreach (Button b in PetButtons)
        {
            b.interactable = true;
        }
    }

    // finds first pet that is interactable 
    public int FindFirstOpenPet()
    {
        for (int i = 0; i < 6; ++i)
        {
            if (PetButtons[i].interactable == true)
            {
                petToSet = GameObject.Find("PetSelector").GetComponent<Pet>();
                petToSet.SetModel(i);
                return i;
            }
        }
        Debug.Log("Something went wrong");
        return 1;
    }

    // Displays character at given index
    public void SetModel(int index)
    {
        ClearModels();
        ResetInteractable();
        Characters[index].SetActive(true);
        currIndex = index;
    }

    // if pet is currently selected, call FindFirstOpenPet and change the selected pet
    public void CheckValidCombo(int index)
    {
        if(s.GetCurrentOutline() == index)
        {
            int petIndex = FindFirstOpenPet();
            s.Deactivate(petIndex);
            s.Activate(petIndex);
        }
    }

    // Spawns set character
    public void CharacterOne()
    {
        CharaIndex = 0;
        SetModel(CharaIndex);
        PetButtons[5].interactable = false;
        CheckValidCombo(5);
    }

    public void CharacterTwo()
    {
        CharaIndex = 2;
        SetModel(CharaIndex);
        PetButtons[3].interactable = false;
        CheckValidCombo(3);
    }

    public void CharacterThree()
    {
        CharaIndex = 4;
        SetModel(CharaIndex);
        PetButtons[2].interactable = false;
        CheckValidCombo(2);
    }

    public void CharacterFour()
    {
        CharaIndex = 6;
        SetModel(CharaIndex);
        PetButtons[0].interactable = false;
        CheckValidCombo(0);
    }

    public void CharacterFive()
    {
        CharaIndex = 8;
        SetModel(CharaIndex);
        PetButtons[2].interactable = false;
        CheckValidCombo(2);
    }

    public void CharacterSix()
    {
        CharaIndex = 10;
        SetModel(CharaIndex);
        PetButtons[1].interactable = false;
        CheckValidCombo(1);
    }

    public void CharacterSeven()
    {
        CharaIndex = 12;
        SetModel(CharaIndex);
        PetButtons[4].interactable = false;
        CheckValidCombo(4);
    }

    public void CharacterEight()
    {
        CharaIndex = 14;
        SetModel(CharaIndex);
        PetButtons[5].interactable = false;
        CheckValidCombo(5);
    }

    public void CharacterNine()
    {
        CharaIndex = 16;
        SetModel(CharaIndex);
        PetButtons[0].interactable = false;
        CheckValidCombo(0);
    }

    public void CharacterTen()
    {
        CharaIndex = 18;
        SetModel(CharaIndex);
        PetButtons[4].interactable = false;
        CheckValidCombo(4);
    }

    public void CharacterEleven()
    {
        CharaIndex = 20;
        SetModel(CharaIndex);
        PetButtons[3].interactable = false;
        CheckValidCombo(3);
    }

    public void CharacterTwelve()
    {
        CharaIndex = 22;
        SetModel(CharaIndex);
        PetButtons[1].interactable = false;
        CheckValidCombo(1);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("CharaIndex", CharaIndex);
    }
}
