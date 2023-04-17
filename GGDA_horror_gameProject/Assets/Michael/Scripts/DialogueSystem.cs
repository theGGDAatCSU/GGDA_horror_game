using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour
{
    [Header("CONVERSATION BLOCKS")]
    [SerializeField] TMP_Text npcTextBox_BlockA;
    [SerializeField] TMP_Text Option1_BlockA;
    [SerializeField] TMP_Text Option2_BlockA;
    [SerializeField] TMP_Text Option3_BlockA;

    [SerializeField] TMP_Text npcTextBox_BlockB;
    [SerializeField] TMP_Text Option1_BlockB;
    [SerializeField] TMP_Text Option2_BlockB;
    [SerializeField] TMP_Text Option3_BlockB;

    [SerializeField] TMP_Text npcTextBox_BlockC;
    [SerializeField] TMP_Text Option1_BlockC;
    [SerializeField] TMP_Text Option2_BlockC;
    [SerializeField] TMP_Text Option3_BlockC;

    [SerializeField] TMP_Text npcTextBox_BlockD;
    [SerializeField] TMP_Text Option1_BlockD;
    [SerializeField] TMP_Text Option2_BlockD;
    [SerializeField] TMP_Text Option3_BlockD;

    [SerializeField] TMP_Text npcTextBox_BlockE;
    [SerializeField] TMP_Text Option1_BlockE;
    [SerializeField] TMP_Text Option2_BlockE;
    [SerializeField] TMP_Text Option3_BlockE;

    // Ending Text Variables
    [Header("ENDING BLOCKS")]
    [SerializeField] TMP_Text npcTextBox_BlockD_ending1;
    [SerializeField] TMP_Text npcTextBox_BlockE_ending2;
    [SerializeField] TMP_Text npcTextBox_BlockE_ending3;
    [SerializeField] GameObject DialogueBox_npcTextBox_BlockD_ending1;
    [SerializeField] GameObject DialogueBox_npcTextBox_BlockE_ending2;
    [SerializeField] GameObject DialogueBox_npcTextBox_BlockE_ending3;

    [Header("DIALOGUE BOXES")]
    public GameObject DialogueBox_BlockA;
    public GameObject DialogueBox_BlockB;
    public GameObject DialogueBox_BlockC;
    public GameObject DialogueBox_BlockD;
    public GameObject DialogueBox_BlockE;

    private void Awake()
    {        
        CreateDialogueTrees();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    //---------------------------------------------------------
    // Here are all the Conversation Blocks for this Interaction (Logic and Scene Transtions included)
    //----------------------------------------------------------
    public void CreateDialogueTrees()
    {

        // Sets the Dialogue Text for this Conversation - Block A
        npcTextBox_BlockA.text = "STRANGER \n 'Greetings, friend'";
        Option1_BlockA.text = "'Oh, Hello. Who are you?'";
        Option2_BlockA.text = "'Whoa, where’d you come from? Got a name, pal?'";
        Option3_BlockA.text = "[Leave conversation]";

        // Sets the Dialogue Text for this Conversation - Block B
        npcTextBox_BlockB.text = "STRANGER \n 'My friends call me Ishmael. And whom do I have the pleasure of speaking with?'";
        Option1_BlockB.text = "'I’m [Player Name here]'";
        Option2_BlockB.text = "'Umm, hi. Yeh, the name’s Cornelius.'";
        Option3_BlockB.text = "[Leave conversation]";

        
        // Sets the Dialogue Text for this Conversation - Block C
        npcTextBox_BlockC.text = "ISHMAEL \n 'It’s an honor and a privilege to meet you'";
        Option1_BlockC.text = "'Have you seen anyone else here?'";
        Option2_BlockC.text = "'So, you’re wondering about the woods alone? Is there anyone with you?'";
        Option3_BlockC.text = "[Leave conversation]";

        
        // Sets the Dialogue Text for this Conversation - Block D
        npcTextBox_BlockD.text = "ISHMAEL \n 'Only you, nobody comes out here this late, come on, we should get you back to town, it can be dangerous out here.'";
        Option1_BlockD.text = "'Did you lock me in that cabin?'";
        Option2_BlockD.text = "'I don’t think so. I’ll be fine on my own. Leave me alone'";
        // ## EDNING 1 ## [Angry FACE on cultist] [Ending 1 Conversation]
        Option3_BlockD.text = "[Leave conversation]";

        
        // Sets the Dialogue Text for this Conversation -Block E
        npcTextBox_BlockE.text = "ISHMAEL \n Lock you in the Cabin? I’d never harm another person, unless it was for their own good. Myself and my family have only the best interest for people in need. We saw your car on the road, we can help get it fixed if you’d like.'";
        Option1_BlockE.text = "'You seem quite calm and collected. Sure thing, I’ll take you up on your offer. I’ll thank your family in person if I can.'";
        // ## ENDING 2 ## [HAPPY face Cultist][Ending 2 Conversation] 
        Option2_BlockE.text = "'I don’t think so. I’ll be fine on my own. Leave me alone'";
        // ## ENDING 3 ## [Angry FACE on cultist] [Ending 1 Conversation]
        Option3_BlockE.text = "[Leave conversation]";


        // -------------------------------------------------------
        // ##ENDING## Conversation Blocks
        // -------------------------------------------------------
        // Sets the Dialogue Text for this Conversation -Block D - Ending 1
        npcTextBox_BlockD_ending1.text = "ISHMAEL \n 'You shouldn’t have come here.'";
        // Sets the Dialogue Text for this Conversation -Block E - Ending 2
        npcTextBox_BlockE_ending2.text = "ISHMAEL \n 'You are just the kind of person we’d love to get to know.'";
        // Sets the Dialogue Text for this Conversation -Block E - Ending 3
        npcTextBox_BlockE_ending3.text = "ISHMAEL \n 'You have denied our hospitality? We will show you the true meaning of humbleness.'";
  
    }

    // Decision Tree METHODS

    //Block A
    //
    //
    public void BlockAOption1()
    {
        DialogueBox_BlockB.SetActive(true);

        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockE.SetActive(false);
    }

    public void BlockAOption2()
    {
        DialogueBox_BlockB.SetActive(true);

        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockE.SetActive(false);
    }

    public void BlockAOption3()
    {
        Initiate.Fade("Ending_scene4", Color.black, 0.2f);
        //Invoke("LoadEnding4", 3.0f);
    }

    // Block B
    //
    //
    public void BlockBOption1()
    {
        DialogueBox_BlockC.SetActive(true);

        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockE.SetActive(false);
    }

    public void BlockBOption2()
    {
        DialogueBox_BlockC.SetActive(true);

        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockE.SetActive(false);
    }

    public void BlockBOption3()
    {
        Initiate.Fade("Ending_scene4", Color.black, 0.2f);
    }

    // Block C
    //
    //
    public void BlockCOption1()
    {
        DialogueBox_BlockD.SetActive(true);

        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockE.SetActive(false);
    }

    public void BlockCOption2()
    {
        DialogueBox_BlockD.SetActive(true);

        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockE.SetActive(false);
    }

    public void BlockCOption3()
    {
        Initiate.Fade("Ending_scene4", Color.black, 0.2f);
    }

    //Block D
    //
    //
    public void BlockDOption1()
    {
        // Sets Conversation Block E ACTIVE
        DialogueBox_BlockE.SetActive(true);
        
        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);

    }

    public void BlockDOption2()
    {
        //Sets Ending 1 - dialogue box ACTIVE
        DialogueBox_npcTextBox_BlockD_ending1.SetActive(true);
        DialogueBox_npcTextBox_BlockE_ending2.SetActive(false);
        DialogueBox_npcTextBox_BlockE_ending3.SetActive(false);

        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockE.SetActive(false);

        Initiate.Fade("Ending_scene1", Color.red, 0.2f);
    }

    public void BlockDOption3()
    {
        Initiate.Fade("Ending_scene4", Color.black, 0.2f);
    }

    //Block E
    //
    //
    public void BlockEOption1()
    {
        //Sets Ending 2 - dialogue box ACTIVE
        DialogueBox_npcTextBox_BlockD_ending1.SetActive(false);
        DialogueBox_npcTextBox_BlockE_ending2.SetActive(true);
        DialogueBox_npcTextBox_BlockE_ending3.SetActive(false);

        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockE.SetActive(false);

        Initiate.Fade("Ending_scene2", Color.white, 0.2f);
    }

    public void BlockEOption2()
    {
        //Sets Ending 3 - dialogue box ACTIVE
        DialogueBox_npcTextBox_BlockD_ending1.SetActive(false);
        DialogueBox_npcTextBox_BlockE_ending2.SetActive(false);
        DialogueBox_npcTextBox_BlockE_ending3.SetActive(true);

        DialogueBox_BlockD.SetActive(false);
        DialogueBox_BlockC.SetActive(false);
        DialogueBox_BlockB.SetActive(false);
        DialogueBox_BlockA.SetActive(false);
        DialogueBox_BlockE.SetActive(false);

        Initiate.Fade("Ending_scene3", Color.red, 0.1f);
    }

    public void BlockEOption3()
    {
        Initiate.Fade("Ending_scene4", Color.black, 0.1f);
    }

}
