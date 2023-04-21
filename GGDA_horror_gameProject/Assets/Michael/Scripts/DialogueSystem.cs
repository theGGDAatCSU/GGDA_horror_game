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
        npcTextBox_BlockB.text = "STRANGER \n'I’m Theodore but my friends call me Teddy. I don’t want to hog the spotlight though, who are you?'";
        Option1_BlockB.text = "'I’m Arthur Coril'";
        Option2_BlockB.text = "'(Lie) Nice to meet you Theodore, I’m Arin Esman'";
        Option3_BlockB.text = "[Leave conversation]";

        
        // Sets the Dialogue Text for this Conversation - Block C
        npcTextBox_BlockC.text = "THEODORE \n 'Well it’s a pleasure to meet you.'";
        Option1_BlockC.text = "'Have you seen anyone else here?'";
        Option2_BlockC.text = "'So, you’re wondering about the woods alone? Is there anyone with you?'";
        Option3_BlockC.text = "[Leave conversation]";

        
        // Sets the Dialogue Text for this Conversation - Block D
        npcTextBox_BlockD.text = "THEODORE \n 'Only you, nobody comes out here this late, come on, we should get you back to town, it can be dangerous out here.'";
        Option1_BlockD.text = "'Have you seen anyone around who might have locked me in that cabin?'";
        Option2_BlockD.text = "'Thanks for the hospitality but I’ll be fine on my own. It’s not exactly smart to trust some rube in the woods.'";
        // ## EDNING 1 ## [Angry FACE on cultist] [Ending 1 Conversation]
        Option3_BlockD.text = "[Leave conversation]";

        
        // Sets the Dialogue Text for this Conversation -Block E
        npcTextBox_BlockE.text = "THEODORE \n Lock you in the Cabin? No, I don't think anyone did that. Sometimes the old cabin door catches itself and locks when it closes. Most of us who come out here to hunt have our own copy of the key so we haven’t cared to fix it yet. Sorry that happened to you friend, what say you and I head back to town and get you a meal and maybe a tow truck to the mechanic's place?'";
        Option1_BlockE.text = "'I would appreciate that, now that I think on it, I am fairly hungry.'";
        // ## ENDING 2 ## [HAPPY face Cultist][Ending 2 Conversation] 
        Option2_BlockE.text = "'A hunting cabin with a door that locks on the outside? You all just so happen to have keys? That’s it, I’m getting  out of here!'";
        // ## ENDING 3 ## [Angry FACE on cultist] [Ending 1 Conversation]
        Option3_BlockE.text = "[Leave conversation]";


        // -------------------------------------------------------
        // ##ENDING## Conversation Blocks
        // -------------------------------------------------------
        // Sets the Dialogue Text for this Conversation -Block D - Ending 1
        npcTextBox_BlockD_ending1.text = "THEODORE \n 'If you say so.'";
        // Sets the Dialogue Text for this Conversation -Block E - Ending 2
        npcTextBox_BlockE_ending2.text = "THEODORE \n 'You know, there are some people in town I’d love for you to meet. You can I’ll introduce them while the mechanic works on your car.'";
        // Sets the Dialogue Text for this Conversation -Block E - Ending 3
        npcTextBox_BlockE_ending3.text = "THEODORE \n 'I think you might be too smart for your own good my friend. Try keeping that to yourself next time, you’ve just lost the privilege of calling me Teddy.'";
  
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
