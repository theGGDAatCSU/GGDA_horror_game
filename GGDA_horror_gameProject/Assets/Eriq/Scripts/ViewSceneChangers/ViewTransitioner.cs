using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ViewTransitioner : MonoBehaviour
{
    // [Michael] - Variables for Item Descriptionin UI
    [Header("Item Desciption UI")]
    [SerializeField] TMP_Text interactorDescription;

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
            //[Michael] - Clear Item Description UI Panel when transitioning
            interactorDescription.text = "";
        }
        
    }
}
