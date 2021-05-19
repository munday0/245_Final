using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
