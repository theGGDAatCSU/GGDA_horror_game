using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public enum InteractType 
    { 
        collectible, door, npc, basicInteractable
    }

    
    public InteractType interactType;
    public GameObject objectPrefab;
    public Sprite objectSprite;
    public string description;
    
    public void CollectObject()
    {

    }
    public void InteractObject()
    {

    }
}

