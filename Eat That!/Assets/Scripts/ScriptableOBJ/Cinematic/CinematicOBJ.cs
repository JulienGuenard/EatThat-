using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "CinematicOBJ", menuName = "EatThis!/Cinematic", order = 1)]
public class CinematicOBJ : ScriptableObject
{
    public List<DialogueOBJ> listDialogue;
    public AudioClip music;
}