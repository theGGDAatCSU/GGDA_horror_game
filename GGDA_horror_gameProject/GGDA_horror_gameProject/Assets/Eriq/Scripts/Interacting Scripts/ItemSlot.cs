using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{

    public void EquipItem()
    {
        GameManager.cursorType = GameManager.CursorType.Use;
        GameManager.playerHolding = GameManager.FindItem(gameObject.transform.GetSiblingIndex());
        Sprite sprite = gameObject.GetComponent<Image>().sprite;
        Cursor.SetCursor(sprite.texture, Vector2.zero, CursorMode.Auto);
    }
}
