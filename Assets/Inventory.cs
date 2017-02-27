﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public List<Item> inventory = new List<Item>();
    private ItemDatabase database;
    // Use this for initialization
	void Start () {
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        inventory.Add(database.items[0]);
        inventory.Add(database.items[1]);
        Debug.Log("check inven." + inventory[0].itemName);
        Debug.Log("check inven." + inventory[1].itemName);
    }

    void OnGUI()
    {
        for (int i =0;i<inventory.Count;i++)
        {
            GUI.Label(new Rect(10, i*20, 200, 50), inventory[i].itemName);
        }
    }
}
