using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentSelection;
    public static CharacterControl Instance;

    public List<Villager> list;
    public TMP_Dropdown dropdown;

    private void Start()
    {
        Instance = this;
    }
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        Instance.currentSelection.text = villager.ToString();
    }

    //private void Update()
    //{
    //    if(SelectedVillager != null)
    //    {
    //        currentSelection.text = SelectedVillager.GetType().ToString();
    //   }
    //}

    public void CharacterChanged(Int32 value)
    {
        CharacterControl.SetSelectedVillager(list[value]);
        Debug.Log(dropdown.options[value].text);
    }
}
