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
* Pet script - accounts for switching between pets
*/

public class SelectionTracker : MonoBehaviour
{
    public Button C; // active button
    public Outline O;
    private bool IsActive; //will we need this?

    // activate (pass in), deactivate, updateActive(pass in clicked button) (assign to onClick + variable)
    // all buttons outline --> click (deactivate and update)
    // .setActive (go)--> .enabled (com)
    // default select

    //Q: how do we pass the previous button??

    void Activate(Outline B) //activates outline
    {
        B.enabled = true;
        IsActive = true;
        
    }

    void Deactivate(Outline B) //deactivates outline
    {
        B.enabled = false;
        IsActive = false;
    }

    public void UpdateActive(Outline B) //NOT WORKING PROPERLY -> multiple can still be selected
    {
        if (IsActive)
        {
            Deactivate(B);
        }
        else
        {
            Activate(B);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateActive(O);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
