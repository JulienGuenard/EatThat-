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
        float letterSoundDelay = 2;
        float letterSoundDelayCur = 0;
        for(int i = 0; i < dialogueOBJ.dialogueText.Length; i++)
        {
            dialoguePosition.dialoguePortraitCur.dialogue.text = dialogueOBJ.dialogueText.Substring(0, i);
            letterSoundDelayCur++;

            if (letterSoundDelayCur >= letterSoundDelay)
            {
                    letterSoundDelayCur = 0;
                    dialogueSound.PlayLetter();
            }

            yield return new WaitForSeconds(dialogueOBJ.letterDelay);
        }
    }
}
