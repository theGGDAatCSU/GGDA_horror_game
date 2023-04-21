using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class storyScroll : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public bool isTyping;

    public int index;

    public string filePath;
    private int fileIndex;

    public Sprite[] backgrounds;
    public Image bg;

    public CanvasGroup black;
    private bool fadeIn = false;
    private bool fadeOut = false;

    //transitions
    public void FadeIn()
    {
        fadeIn = true;
    }
    public void FadeOut()
    {
        fadeOut = true;
    }

    public void ChangeBG(int index)
    {
        bg.sprite = backgrounds[index];
    }


    private void Start()
    {
        textComponent.text = string.Empty;
        StartText();
    }
    void StartText()
    {
        index = 0;
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        isTyping= true;
        if (lines.Length> 0)
        {
            foreach (char c in lines[index].ToCharArray())
            {
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
            textComponent.text += "\n\n(Click to continue)";
            isTyping = false;
        }
        
    }

    void NextLine()
    {
        if(isTyping)
        {
            
            textComponent.text = lines[index];
            StopAllCoroutines();
            isTyping = false;
            textComponent.text += "\n\n(Click to continue)";


        }
        else if(!isTyping)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(Type());
        }
    }



    private void Awake()
    {
        filePath = Application.dataPath + "/Caleb/Art/Lines/intro lines 1.txt";

        string[] newLines = File.ReadAllLines(filePath);
        print(newLines.Length);
    }

    void Update()
    {
        if (fadeIn)
        {
            if (black.alpha < 1)
            {
                black.alpha += Time.deltaTime;
                if (black.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }
        if (fadeOut)
        {
            if (black.alpha > 0)
            {
                black.alpha -= Time.deltaTime;
                if (black.alpha <= 0)
                {
                    fadeOut = false;
                }
            }
        }



        if (Input.GetMouseButtonDown(0))
        {
            if (index == 6)
            {
                FadeIn();

            }
            if (index == 7)
            {

                ChangeBG(1);
                FadeOut();
            }
            if (index == 10)
            {
                FadeIn();

            }
            if (index == 11)
            {

                ChangeBG(2);
                FadeOut();
            }
            if (index == 14)
            {
                FadeIn();

            }
            if (index == 15)
            {

                ChangeBG(3);
                FadeOut();
            }
            if (index == 16)
            {
                SceneManager.LoadScene(2);
            }
            NextLine();
            
        }
    }
}
