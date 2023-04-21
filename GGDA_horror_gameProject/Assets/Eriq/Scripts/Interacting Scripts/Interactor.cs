using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactor : MonoBehaviour
{
    // [Michael] - Variables for Item Descriptionin UI
    [Header("Item Desciption UI")]
    [SerializeField] TMP_Text interactorDescription;

    void Update()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (hit != null)
            {
                if(hit.transform != null)
                    CurrentClickedGameObject(hit.transform.gameObject);

            }
        }
        if (Input.GetMouseButton(1))
        {
            GameManager.ClearHeldItem();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(GameManager.FindItem(0));
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject)
    {
        if(GameManager.cursorType == GameManager.CursorType.Inspect)
        {
            Inspect(gameObject);
        }
        else if(GameManager.cursorType == GameManager.CursorType.Interact)
        {
            Interact(gameObject);
        }
        else if(GameManager.cursorType == GameManager.CursorType.Use)
        {
            Use(gameObject);
        }
    }
    private void Inspect(GameObject gameObject)
    {
        Interactable item = gameObject.GetComponent<Interactable>();
        if (item != null)
        {
            //Debug.Log(item.description);
            // [Michael] - commented this code out and added code below
            interactorDescription.text = item.description;
            //
        }
    }

    private void Interact(GameObject gameObject)
    {
        Interactable item = gameObject.GetComponent<Interactable>();
        if (item != null)
        {
            if (item.interactType == Interactable.InteractType.collectible)
            {
                Debug.Log(gameObject.GetComponent<Collectible>().objectPrefab);
                GameManager.AddItem(gameObject.GetComponent<Collectible>().objectPrefab);

                Destroy(item.gameObject);
            }
            if (item.interactType == Interactable.InteractType.door)
            {

                Open(gameObject);
            }
        }
    }

    private void Use(GameObject gameObject)
    {
        Interactable item = gameObject.GetComponent<Interactable>();
        if (item.interactType == Interactable.InteractType.door)
        {

            Unlock(gameObject);
        }
    }

    private void Open(GameObject item)
    {
        Door door = item.GetComponent<Door>();
        if (door.locked)
        {
            Debug.LogWarning(door.lockedText);
        }
        else if (!door.locked)
        {
            ViewTransitioner view = item.GetComponent<ViewTransitioner>();
            if (view != null)
            {
                if (!view.isSceneTransition)
                {
                    GameManager.ChangeView(view.view);
                }
                else
                {
                    GameManager.ChangeScene(view.scene);
                }
            }
        }
    }

    private void Unlock(GameObject item)
    {
        Door door = item.GetComponent<Door>();
        
        if (door.locked && GameManager.playerHolding != null)
        {
            Debug.Log("Item is a door");
            door.TryOpening(GameManager.playerHolding);
        }
    }

    
}
