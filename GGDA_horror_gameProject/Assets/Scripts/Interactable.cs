using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
<<<<<<< Updated upstream
    public bool collectible;
    public bool door;
    public GameObject objectPrefab;
    public Sprite objectSprite;
=======
    public enum InteractType 
    { 
        collectible, door, npc, basicInteractable
    }

    
    public InteractType interactType;
    public GameObject objectPrefab;
    public Sprite objectSprite;
    public string description;
>>>>>>> Stashed changes
    
    public void CollectObject()
    {

    }
    public void InteractObject()
    {

    }
}
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
