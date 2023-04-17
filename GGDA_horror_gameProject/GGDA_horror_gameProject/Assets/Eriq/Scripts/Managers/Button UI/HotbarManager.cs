using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarManager : MonoBehaviour
{
    public GameObject setHotbar;
    public static GameObject hotbar;
    public GameObject setSlotPrefab;
    public static GameObject slotPrefab;


    public void Awake()
    {
        hotbar = setHotbar;
        slotPrefab = setSlotPrefab;
    }
    public static void CreateItem(GameObject item)
    {
        if (hotbar.activeSelf)
        {
            GameObject newItemSlot = Instantiate(slotPrefab);
            newItemSlot.GetComponent<Image>().sprite = item.GetComponent<Collectible>().objectSprite;
            newItemSlot.transform.parent = hotbar.transform;
        }
    }
    public static void DeleteItems()
    {
        if(hotbar.transform.childCount > 0 && hotbar.activeSelf)
        {
            foreach (Transform child in hotbar.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
        
    }
}
