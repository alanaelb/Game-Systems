using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearDialogue : Dialogue
{
    private void OnGUI()
    {
        // if our dialogue can be seen on screen
        if (showDialogue) 
        {
            // the dialogue box takes up the whole bottom 3rd of the screen and displays the NPC's name and current dialogue
            GUI.Box(UIHandler.ScreenPlacement(6, 7.25f, 4, 0.75f), "Hello Summoner!");
            GUI.Box(UIHandler.ScreenPlacement(0, 6f, 16, 3), speakersName+": " + dialogueText[currentLineOfText]);
            // if not at the end of the dialogue 

            if (currentLineOfText < dialogueText.Length-1)
            {

                //next button allows us to skip forward to the next line of dialogue 
               if( GUI.Button(UIHandler.ScreenPlacement(15, 8.5f, 1, 0.5f), "Next"))
                {
                    // incrementing currentLineIndex by 1 so tht we go to next ine
                   currentLineOfText = currentLineOfText+1; 
                }
            }
            //else we are at the end 
            else
            { // the Bye buttom allows up to end our dialogue
                if( GUI.Button(UIHandler.ScreenPlacement(15, 8.5f, 1, 0.5f), "Bye"))
                {
                    //currentLineOfText = currentLineOfText+1
                    // close the dialogue box 
                    CloseDialogue();
                }
            }

        }
    }
}
