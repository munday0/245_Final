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
        //Debug.Log("In DisplayName");
        CharacterName = CharacterInputField.GetComponent<Text>().text;
        PetName = PetInputField.GetComponent<Text>().text;
        CharacterTextDisplay.GetComponent<Text>().text = CharacterName;
        PetTextDisplay.GetComponent<Text>().text = PetName;
        //Canvas.transform.Find("CharacterNameInput/Text").GetComponent<Text>();
        //PetName = Canvas.transform.Find("PetNameInput/Text").GetComponent<Text>();
        //CharacterName.text = "check1";
        //PetName.text = "sadness";
        //string charName = CharacterName.text.ToString();
        //string petName = PetName.text.ToString();
    }
}
