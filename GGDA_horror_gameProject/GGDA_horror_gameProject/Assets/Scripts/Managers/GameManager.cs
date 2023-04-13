using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Controls what the user can do with their cursor
    public enum CursorType
    {
        Inspect, Interact
    }
    public static CursorType cursorType;
    //List of Game Objects
    private static List<GameObject> Items;
    private int currentItemIndex = 0;
    public static GameObject playerHolding;


    public void Awake()
    {
        Items = new List<GameObject>();
    }
    public static void AddItem(GameObject item)
    {
        Items.Add(item);
        UpdateHotbar();
        Debug.Log(Items.Count);
    }
    public static void UpdateHotbar()
    {
        HotbarManager.DeleteItems();
        foreach (GameObject item in Items)
        {
            HotbarManager.CreateItem(item);
        }
    }

}
