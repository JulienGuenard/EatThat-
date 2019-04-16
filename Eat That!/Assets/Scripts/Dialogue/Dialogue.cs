using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [System.Serializable]
    public class DialoguePortrait
    {
        public GameObject parent;
        public TextMeshProUGUI title;
        public TextMeshProUGUI dialogue;
        public Image portrait;
    }

    [Header("References")]
    public List<DialoguePortrait> dialoguePortraitList;

    [HideInInspector] public DialogueOBJ dialogueOBJ;

    [HideInInspector] public DialoguePosition dialoguePosition;
    [HideInInspector] public DialogueText dialogueText;
    [HideInInspector] public DialogueArt dialogueArt;
    [HideInInspector] public DialogueSound dialogueSound;
    [HideInInspector] public AudioSource audioSource;

    [HideInInspector] public DialoguePortrait dialoguePortraitCur;

    // Start is called before the first frame update
    void Awake()
    {
        dialoguePosition = GetComponent<DialoguePosition>();
        dialogueText = GetComponent<DialogueText>();
        dialogueArt = GetComponent<DialogueArt>();
        dialogueSound = GetComponent<DialogueSound>();
        audioSource = GetComponent<AudioSource>();
    }

    public void ReadDialogue(DialogueOBJ dialogue)
    {
        dialogueOBJ = dialogue;
        dialoguePosition.ChangePosition();
        dialogueArt.ChangePortrait();
        dialogueText.ReadText();
    }
}
