using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu : MonoBehaviour
{

    public LudusData _LudusData;
    public GameObject menu;
    public GameObject fieldMenu;
    public GameObject buildMenu;
    public GameObject kitchenMenu;
    public GameObject villaMenu;
    public GameObject warriorMenu;
    public GameObject arenaMenu;
    public GameObject slaveMenu;
    public GameObject warehouseMenu;

    public List<GameObject> Menus;


    public void MenuAction(string type)
    {
        
        switch(type)
        {
            case "field":
                menu.SetActive(true);
                fieldMenu.SetActive(true);
                break;

            case "build":
                menu.SetActive(true);
                buildMenu.SetActive(true);
                break;

            case "kitchen":
                menu.SetActive(true);
                kitchenMenu.SetActive(true);
                break;

            case "villa":
                menu.SetActive(true);
                villaMenu.SetActive(true);
                break;

            case "warrior":
                menu.SetActive(true);
                warriorMenu.SetActive(true);
                break;

            case "slave":
                menu.SetActive(true);
                slaveMenu.SetActive(true);
                break;

            case "arena":
                menu.SetActive(true);
                arenaMenu.SetActive(true);
                break;

            case "warehouse":
                menu.SetActive(true);
                warehouseMenu.SetActive(true);
                break;

            case "close":
                foreach(GameObject menu in Menus)
                {
                    menu.SetActive(false);
                }
                menu.SetActive(false);
                break;
        }
    }

    
    
}

    