using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    public TMP_Text classUI;

    public static void SetSelectedVillager(Villager villager)
    {

        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        
        SelectedVillager.Selected(true); 
    }

    private void Update()
    {
        classIndicator();
    }

    void classIndicator()
    {
        if (SelectedVillager == null)
        {
            classUI.text = "Villager";
        }

        if (SelectedVillager != null)
        {
            classUI.text = SelectedVillager.GetType().Name;
        }
    }
    
}
