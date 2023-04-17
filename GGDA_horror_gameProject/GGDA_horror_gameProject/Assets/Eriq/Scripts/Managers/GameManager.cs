using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Controls what the user can do with their cursor
    public enum CursorType
    {
        Inspect, Interact, Use
    }
    public static CursorType cursorType;
    //List of Game Objects
    private static List<GameObject> Items;
    public static GameObject playerHolding;

    public static GameObject cameraObject;

    public void Awake()
    {
        Items = new List<GameObject>();
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");
    }

    public static void AddItem(GameObject item)
    {
        Items.Add(item);
        UpdateHotbar();
        Debug.Log(Items.Count);
    }

    public static void DeleteItem(GameObject item)
    {
        Items.Remove(item);
        UpdateHotbar();
        Debug.Log(Items.Count);
    }
    public static void UpdateHotbar()
    {
        HotbarManager.DeleteItems();
        foreach (GameObject item in Items)
        {
            HotbarManager.CreateItem(item);
        }
    }

    public static GameObject FindItem(int index)
    {
        
        return Items[index];
    }
    public static void ClearHeldItem()
    {
        Debug.Log("resetting cursor");
        GameManager.playerHolding = null;
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }

    public static void ChangeCursor(Texture2D mouse)
    {
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.Auto);
    }

    public static void ChangeView(Transform view)
    {
        cameraObject.transform.position = view.position;
    }
    public static void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
