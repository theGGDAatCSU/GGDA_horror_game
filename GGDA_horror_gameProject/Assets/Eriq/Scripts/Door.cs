using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Door : MonoBehaviour
{

    // [Michael] - Variables for Item Descriptionin UI
    [Header("Item Desciption UI")]
    [SerializeField] TMP_Text interactorDescription;

    public bool locked = true;
    public GameObject attachedKey;

    public Sprite interactedSprite;

    public string lockedText = "The Door is locked... there has to be a key around here somewhere";
    public string wrongItemText = "This door needs a key. It must be around here somewhere";
    public string openingDoorText = "The door swings open, letting the cold air of the outside come in.";

    public void TryOpening(GameObject item)
    {
        if (item == attachedKey)
        {
            locked = false;
            Image image = gameObject.GetComponent<Image>();
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            if (image!= null)
            {
                image.sprite = interactedSprite;
            }
            else if(spriteRenderer != null)
            {
                spriteRenderer.sprite = interactedSprite;
            }
            
            GameManager.DeleteItem(item);
            //Debug.Log(openingDoorText);
            // [Michael] - commented this code out and added code below
            interactorDescription.text = openingDoorText;
            //
        }
        else
        {
            //Debug.Log(wrongItemText);
            // [Michael] - commented this code out and added code below
            interactorDescription.text = wrongItemText;
            //
        }
    }
}
