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
    public List<Outline> Outlines; //= new Outline[];
    private int previousIndex = -1;
    //private bool IsActive; //will we need this?

    // activate (pass in), deactivate, updateActive(pass in clicked button) (assign to onClick + variable)
    // all buttons outline --> click (deactivate and update)
    // .setActive (go)--> .enabled (com)
    // default select

    //Q: how do we pass the previous button??

    void Activate(int index/*Outline B*/) //activates outline
    {
        Outlines[index].enabled = true;
        previousIndex = index;
    }

    void Deactivate(int index) //deactivates outline
    {
        Outlines[previousIndex].enabled = false;
    }

    public void UpdateActive(int index) // OnClick
    {
        if (Outlines[index].enabled == false)
        {
            if (previousIndex > -1)
            {
                Deactivate(previousIndex);
            }
            if (index != previousIndex)
            {
                
                Activate(index);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateActive(0);
    }
}
