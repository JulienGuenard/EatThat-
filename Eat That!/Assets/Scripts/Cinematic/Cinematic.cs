using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematic : MonoBehaviour
{
    public CinematicOBJ cinematicOBJ;
    public Dialogue dialogue;

    [HideInInspector] public AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        StartMusic();
        ReadDialogue(0);
    }

    public void ReadDialogue(int id)
    {
        dialogue.ReadDialogue(cinematicOBJ.listDialogue[id]);
    }

    private void StartMusic()
    {
        audioSource.clip = cinematicOBJ.music;
        audioSource.Play();
    }

    private void StopMusic()
    {
        audioSource.Stop();
    }
}
