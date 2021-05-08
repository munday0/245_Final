using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Stephanie Munday
 * ID: 2343625
 * smunday@chapman.edu
 * CPSC 245-01
 * Final - Character Select
 *
 * Character script - accounts for switching between characters
 */

public class Character : MonoBehaviour
{
    public GameObject[] Characters = new GameObject[4]; //list of different character objects to be chosen from

    public int CharaIndex = 0; //index of character object

    // Start is called before the first frame update
    void Start()
    {
        //InstantiateCharacter();
    }

    public void SwitchCharacter()
    {
        Characters[CharaIndex].SetActive(false);
        CharaIndex = (CharaIndex + 1) % Characters.Length;
        Characters[CharaIndex].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("CharaIndex", CharaIndex);
    }



    //public void InstantiateCharacter()
    //{
    //    Instantiate(Characters[CharaIndex], transform.position, transform.rotation, transform);
    //    Debug.Log("Chara Index:" + CharaIndex);
    //}

    //public void ChangeCharacter() //6:16
    //{
    //    for (int i = 0; i < Characters.Length; i++)
    //    {
    //        if (i == CharaIndex)
    //        {
    //            Characters[i].SetActive(true);
    //        }
    //        else
    //        {
    //            Characters[i].SetActive(false);
    //        }
    //    }
    //}


    //public void SelectF1()
    //{
    //    CharaIndex = 0;
    //    //InstantiateCharacter();
    //    ChangeCharacter();
    //    Debug.Log("F1");
    //}

    //public void SelectF2()
    //{
    //    CharaIndex = 1;
    //    //InstantiateCharacter();
    //    ChangeCharacter();
    //    Debug.Log("F2");
    //}

    //public void SelectM1()
    //{
    //    CharaIndex = 2;
    //    //InstantiateCharacter();
    //    ChangeCharacter();
    //    Debug.Log("M1");
    //}

    //public void SelectM2()
    //{
    //    CharaIndex = 3;
    //    //InstantiateCharacter();
    //    ChangeCharacter();
    //    Debug.Log("M2");
    //}

    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        SelectF1();
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        SelectF2();
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha3))
    //    {
    //        SelectM1();
    //    }
    //    if (Input.GetKeyDown(KeyCode.Alpha4))
    //    {
    //        SelectM2();
    //    }
    //}


}
