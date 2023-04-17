using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
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
            Debug.Log(openingDoorText);
        }
        else
        {
            Debug.Log(wrongItemText);
        }
    }
}
