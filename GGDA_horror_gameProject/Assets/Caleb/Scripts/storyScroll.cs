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
    private string storyLines = "Business has slowed over the past few months, you took this job because it was the only letter that came by this week that wasn’t either a spam letter or a notice of late payment.\n" +
                                "The job seemed simple, a letter inside detailing a missing woman, four thousand dollars in cash, and a picture of the woman.\n"+
                                "After eight years in the private eye business, one would think you had learned when something is too good to be true.\n" +
                                "Maybe it was the desperation, maybe it was intrigue for receiving a case in such an unusual manner.\n" +
                                "As you drove down the dusty roads, you began to go over details in your mind, missing people were common, often a partner or kid who had run off with a new love, sure it was unfortunate, but it didn’t exactly concern you.Outside of the payday of course.\n" +
                                "The roads stretched on for miles before and behind you, no trees passed through your purview just mile after mile of farmland. You awakened from your stupor when the car coughed on its last few drops of gas and died.\n" +
                                "You were able to pull over to the side of the road in time but standing there on the precipice, your insignificance was magnified. Your eyes locked on the horizon and traced it around you as if a periscope.\n" +
                                "You became enveloped in this plane and lost yourself for a moment, only coming to your senses when an incongruous form pierced the horizon.\n" +
                                "A cabin.\n" +
                                "You had thought that salvation may have come for you.A quaint cabin stood before you, it stood at the end of a long dirt walkway, as most of the houses in these areas did.\n" +
                                "The details of this house were hard to make out in the pale moonlight, the world fell away as the cabin took over your perspective.\n" +
                                "[Knock Knock Knock]\n" +
                                "A hand knocked at the door, your hand. Only the wind answered as the door slowly pulled itself back, revealing a sterile interior. The trappings of civilization were missing from this place, the walls stood bare of decoration and the floors empty of any furniture.\n" +
                                "Unfortunately, it seemed you had found an empty house, fortunately it was still a place to stay, at least until morning when you could walk to the nearest rest stop for gas.\n" +
                                "You trekked through the empty building going from one room to the next each barren save for the final one that you had graced with your presence.\n" +
                                "That presence in your stomach now made sense.Your body had tried to warn you, utilizing a near forgotten primal instinct. One that told you that you were being watched.\n" +
                                "The room was lived in and perhaps most discomforting, the window was barred.\n" +
                                "[Click]\n" +
                                "The Front Door.You rushed to it, only to find it locked.\n" +
                                "What exactly have you gotten yourself into, Detective?";

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

        //---
        //filePath = Application.dataPath + "/Resources/intro lines 1.txt";
        //string[] newLines = File.ReadAllLines(filePath);
        // [Michael] - Had to Hardcode the storyline string because the read file functionality was not working
        // --- We can fix this later

        string[] newLines = storyLines.Split("\n");

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
