﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
	int current_menu = 0;
	public GameObject [] Menus;


	private void Set_next_menu(GameObject [] Menu,int current)
    {
		Menu [current].SetActive (false);
		Menu [current+1].SetActive (true);
	}

    private void Set_previous_menu(GameObject [] Menu, int current)
    {
        Menu[current].SetActive(false);
        Menu[current - 1].SetActive(true);
    }

	public void Next_menu (){
		print ("Menu:" + current_menu);
		switch (current_menu) {
		case 0:
			current_menu++;
            
			Set_next_menu (Menus, 0); 
			break;
		case 1:
			current_menu++;
			Set_next_menu (Menus, 1);
			break;
		case 2:
			//Set_menu (Menus, 2);
			break;
		default:
			break;
		}

	}

    public void Previous_menu()
    {
        print("Menu:" + current_menu);
        switch (current_menu)
        {
            case 0:
                current_menu=0;
                
                break;
            case 2:
                current_menu--;
                Set_previous_menu(Menus, 2);
                break;
            default:
                break;
        }
    }

}