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
 * Character script - accounts for switching between characters
 */

public class Character : MonoBehaviour
{
    public GameObject[] Characters = new GameObject[24]; //list of different character objects to be chosen from

    public int CharaIndex = 0; //index of character object
    private int currIndex;

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
        for(int i = 0; i < Characters.Length; ++i)
        {
            Characters[i].SetActive(false);
        }
    }

    // Displays character at given index
    public void SetModel(int index)
    {
        ClearModels();
        Characters[index].SetActive(true);
        currIndex = index;
    }

    // Spawns set character
    public void CharacterOne()
    {
        CharaIndex = 0;
        SetModel(CharaIndex);
    }

    public void CharacterTwo()
    {
        CharaIndex = 2;
        SetModel(CharaIndex);
    }

    public void CharacterThree()
    {
        CharaIndex = 4;
        SetModel(CharaIndex);
    }

    public void CharacterFour()
    {
        CharaIndex = 6;
        SetModel(CharaIndex);
    }

    public void CharacterFive()
    {
        CharaIndex = 8;
        SetModel(CharaIndex);
    }

    public void CharacterSix()
    {
        CharaIndex = 10;
        SetModel(CharaIndex);
    }

    public void CharacterSeven()
    {
        CharaIndex = 12;
        SetModel(CharaIndex);
    }

    public void CharacterEight()
    {
        CharaIndex = 14;
        SetModel(CharaIndex);
    }

    public void CharacterNine()
    {
        CharaIndex = 16;
        SetModel(CharaIndex);
    }

    public void CharacterTen()
    {
        CharaIndex = 18;
        SetModel(CharaIndex);
    }

    public void CharacterEleven()
    {
        CharaIndex = 20;
        SetModel(CharaIndex);
    }

    public void CharacterTwelve()
    {
        CharaIndex = 22;
        SetModel(CharaIndex);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("CharaIndex", CharaIndex);
    }
}
