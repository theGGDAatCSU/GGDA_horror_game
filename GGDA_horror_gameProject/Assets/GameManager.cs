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
    public GameObject Hotbar;


    public static void AddItem(GameObject item)
    {
        //Items.Add(item);

        
        Debug.Log("Add The Item!!");
    }
    public static void UpdateHotbar()
    {
        /*for (int i; i < Items.Count; i++)
        {

        }*/
    }
    public static void InspectClick()
    {
        cursorType = CursorType.Inspect;
        
    }
    public static void InteractClick()
    {
        cursorType = CursorType.Interact;
    }
    public void BagClick()
    {
        Hotbar.SetActive(!Hotbar.activeSelf);
    }
}
