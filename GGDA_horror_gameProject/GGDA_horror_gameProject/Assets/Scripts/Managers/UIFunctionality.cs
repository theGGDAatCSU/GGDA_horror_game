using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFunctionality : MonoBehaviour
{
    public Sprite openSprite;
    public Sprite closeSprite;
    public GameObject Bagsprite;
    public GameObject Hotbar;

    public static void InspectClick()
    {
        GameManager.cursorType = GameManager.CursorType.Inspect;

    }
    public static void InteractClick()
    {
        GameManager.cursorType = GameManager.CursorType.Interact;
    }
    public void BagClick()
    {
        
        Hotbar.SetActive(!Hotbar.activeSelf);
        if (Hotbar.activeSelf)
        {
            GameManager.UpdateHotbar();
            Bagsprite.GetComponent<Image>().sprite = openSprite;
        }
        else
        {
            Bagsprite.GetComponent<Image>().sprite = closeSprite;
        }
    }
}
