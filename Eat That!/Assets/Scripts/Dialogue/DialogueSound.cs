using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSound : Dialogue
{
     public void PlayLetter()
    {
        audioSource.Stop();
        audioSource.clip = dialogueOBJ.dialogueSound;
        audioSource.Play();
    }
}
