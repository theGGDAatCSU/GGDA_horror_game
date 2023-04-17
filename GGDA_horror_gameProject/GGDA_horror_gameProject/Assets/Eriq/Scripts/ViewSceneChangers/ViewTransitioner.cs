using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewTransitioner : MonoBehaviour
{
    public bool isSceneTransition;
    public int scene;

    public Texture2D moveArrow;
    public Transform view;
    void OnMouseOver()
    {
        if(GameManager.cursorType == GameManager.CursorType.Interact && !gameObject.GetComponent<Door>().locked)
        {
        Debug.Log("ChangingCursor");
        
        GameManager.ChangeCursor(moveArrow);
        }
        
        
    }
    void OnMouseExit()
    {
        if(GameManager.cursorType == GameManager.CursorType.Interact)
        {
            GameManager.ClearHeldItem();
        }
        
    }
}
