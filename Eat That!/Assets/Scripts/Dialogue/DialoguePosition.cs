using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePosition : Dialogue
{
public void ChangePosition()
    {
        for(int i = 0; i < dialoguePortraitList.Count; i++)
        {
            dialoguePortraitList[i].parent.SetActive(false);
            if (dialogueOBJ.portraitPosition == PortraitPosition.Left) dialoguePortraitCur = dialoguePortraitList[0];
            if (dialogueOBJ.portraitPosition == PortraitPosition.Right) dialoguePortraitCur = dialoguePortraitList[1];
        }
        dialoguePortraitCur.parent.SetActive(true);
    }
}
