using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //List of Game Objects
    private static List<GameObject> Items;
    private int currentItemIndex = 0;

    //On Update Update the Hotbar if Items have changed
    void Update()
    {

    }


    public static void AddItem(GameObject item)
    {
        //Items.Add(item);

        Debug.Log("Add The Item!!");
    }
}
