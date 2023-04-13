using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{

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
            else if (item.interactType == Interactable.InteractType.door)
            {
                Debug.Log("Item is a door");
                Door door = item.gameObject.GetComponent<Door>();
                if (door.locked)
                {
                    door.DisplayText();
                }
                else if (door.locked && GameManager.playerHolding)
                {
                    door.TryOpening(gameObject.GetComponent<Collectible>().objectPrefab);
                }
            }
        }
    }

    private void Inspect(GameObject gameObject)
    {
        Interactable item = gameObject.GetComponent<Interactable>();
        if (item != null)
        {
            Debug.Log(item.description);
        }
    }
}
