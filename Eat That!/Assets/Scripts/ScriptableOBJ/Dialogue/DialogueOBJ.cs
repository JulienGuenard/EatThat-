using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "DialogueOBJ", menuName = "EatThis!/Dialogue", order = 1)]
public class DialogueOBJ : ScriptableObject
{
    public string titleText;
    public string dialogueText;
    public float letterDelay;
    public Sprite portrait;
    public PortraitPosition portraitPosition;
    public AudioClip dialogueSound;
}