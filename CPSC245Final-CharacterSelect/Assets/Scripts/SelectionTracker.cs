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

    public void Activate(int index) //activates outline
    {
        Outlines[index].enabled = true;
        previousIndex = index;
    }

    public void Deactivate(int index) //deactivates outline
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

    public int GetCurrentOutline()
    {
        for (int i = 0; i < 6; ++i)
        {
            if (Outlines[i].enabled == true)
                return i;
        }
        Debug.Log("Something went wrong");
        return 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateActive(0);
    }
}
