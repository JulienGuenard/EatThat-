using UnityEngine;

public class Dialogue : MonoBehaviour
{
  public static DialogueOBJ dialogueOBJ;

 public static DialoguePosition dialoguePosition;
public static DialogueText dialogueText;
public static DialogueArt dialogueArt;
 public static DialogueSound dialogueSound;
 public static AudioSource audioSource;

    public static Dialogue inst;

    // Start is called before the first frame update
    void Awake()
    {
        if (!inst) inst = this;
        
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
