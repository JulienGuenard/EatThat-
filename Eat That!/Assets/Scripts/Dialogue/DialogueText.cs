using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueText : Dialogue
{

    public void ReadText()
    {
        dialoguePosition.dialoguePortraitList[0].title.text = dialogueOBJ.titleText;
        StartCoroutine(ReadDialogue());
    }

    private IEnumerator ReadDialogue()
    {
        for(int i = 0; i < dialogueOBJ.dialogueText.Length; i++)
        {
            dialoguePosition.dialoguePortraitCur.dialogue.text = dialogueOBJ.dialogueText.Substring(0, i);
            dialogueSound.PlayLetter();
            yield return new WaitForSeconds(dialogueOBJ.letterDelay);
        }
    }
}
