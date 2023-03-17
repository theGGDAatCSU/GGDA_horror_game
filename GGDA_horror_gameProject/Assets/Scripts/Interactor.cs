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
                    CurrentClickedGameObject(hit.transform.gameObject);

            }
        }
    }

    public void CurrentClickedGameObject(GameObject gameObject)
    {
        Interactable item = gameObject.GetComponent<Interactable>();
        if (item!=null)
        {
            if (item.collectible)
            {
                GameManager.AddItem(item.objectPrefab);
                Destroy(item.gameObject);
            }
            else if (item.door)
            {
                Debug.Log("Item is a door");
            }
        }
    }
}
