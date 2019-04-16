using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialoguePosition : Dialogue
{

    [System.Serializable]
    public class DialoguePortrait
    {
        public GameObject parent;
        public TextMeshProUGUI title;
        public TextMeshProUGUI dialogue;
        public Image portrait;
    }

    public List<DialoguePortrait> dialoguePortraitList;

    [HideInInspector] public DialoguePortrait dialoguePortraitCur;

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
