using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool locked = true;
    public GameObject attachedKey;
    public string lockedText = "The Door is locked... there has to be a key around here somewhere";
    public string wrongItemText = "This door needs a key. It must be around here somewhere";

    public void DisplayText()
    {
        Debug.LogWarning(lockedText);
    }
    public void TryOpening(GameObject item)
    {
        if (item) ;
    }
}
