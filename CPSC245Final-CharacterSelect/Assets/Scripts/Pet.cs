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
* Pet script - accounts for switching between pets
*/

public class Pet : MonoBehaviour
{
    public GameObject[] Pets = new GameObject[9]; //list of different character objects to be chosen from

    public int PetIndex = 0; //index of character object
    private int currIndex;

    private void Start()
    {
        SetModel(0);
    }

    // Toggles through pet skins
    public void SwitchPet()
    {
        if (PetIndex > 4 && PetIndex < 8)
        {
            PetIndex++;
        }
        else if (PetIndex == 8)
        {
            PetIndex = (currIndex) % Pets.Length;
        }
        else
        {
            return;
        }

        ClearModels();
        Pets[PetIndex].SetActive(true);
    }

    // Clear visible characters 
    public void ClearModels()
    {
        for (int i = 0; i < Pets.Length; ++i)
        {
            Pets[i].SetActive(false);
        }
    }

    public void SetModel(int index)
    {
        ClearModels();
        Pets[index].SetActive(true);
        currIndex = index;
    }

    // Spawns set pet
    public void PetOne()
    {
        PetIndex = 0;
        SetModel(PetIndex);
    }

    public void PetTwo()
    {
        PetIndex = 1;
        SetModel(PetIndex);
    }

    public void PetThree()
    {
        PetIndex = 2;
        SetModel(PetIndex);
    }

    public void PetFour()
    {
        PetIndex = 3;
        SetModel(PetIndex);
    }

    public void PetFive()
    {
        PetIndex = 4;
        SetModel(PetIndex);
    }

    public void PetSix()
    {
        PetIndex = 5;
        SetModel(PetIndex);
    }
}
