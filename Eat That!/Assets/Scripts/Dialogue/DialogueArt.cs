using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueArt : Dialogue
{
    public void ChangePortrait()
    {
        dialoguePosition.dialoguePortraitCur.portrait.sprite = dialogueOBJ.portrait;
    }
}
