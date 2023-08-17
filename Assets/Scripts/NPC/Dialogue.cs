using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool showDialogue = false;
    public string speakersName = "";
    public string[] dialogueText;
    public int currentLineOfText = 0;

    // Method that we can access through other scripts
    public void OpenDialogue()
    {
    // trigger bool
    // reset int
    // any other thing you need
        showDialogue = true;
        currentLineOfText = 0; 

    
    }

    public void CloseDialogue()
    {
        showDialogue = false;
        currentLineOfText = 0;  

    }
}
