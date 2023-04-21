using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits_updated_script : MonoBehaviour
{
    [SerializeField] GameObject creditText;
    private float creditMoveSpeed = 40f;
    private float creditTimer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        creditTimer += Time.deltaTime;
        Debug.Log("seconds = " + creditTimer);
        if (creditTimer < 600)
        {
            creditText.transform.Translate(Vector2.up * creditMoveSpeed * Time.deltaTime);
        }
    }


    public void ReturnToMainMenufromCredits()
    {
        SceneManager.LoadScene(0);
    }
}
