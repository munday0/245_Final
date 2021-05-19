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
 * NameUI script - accounts for displaying character and pet names
 */

public class NameUI : MonoBehaviour
{
    public string CharacterName;
    public string PetName;
    public GameObject CharacterInputField;
    public GameObject PetInputField;
    public GameObject CharacterTextDisplay;
    public GameObject PetTextDisplay;

    public void DisplayName()
    {
        CharacterName = CharacterInputField.GetComponent<Text>().text;
        PetName = PetInputField.GetComponent<Text>().text;
        CharacterTextDisplay.GetComponent<Text>().text = CharacterName;
        PetTextDisplay.GetComponent<Text>().text = PetName;
    }
}
