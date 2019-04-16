using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cinematic : MonoBehaviour
{
    public CinematicOBJ cinematicOBJ;
    public Dialogue dialogue;

    void Awake()
    {
        StartMusic();
        ReadDialogue(0);
    }

    public void ReadDialogue(int id)
    {
        dialogue.ReadDialogue(cinematicOBJ.listDialogue[id]);
    }

    private void StartMusic()
    {
        Camera.main.GetComponent<AudioSource>().clip = cinematicOBJ.music;
        Camera.main.GetComponent<AudioSource>().Play();
    }

    private void StopMusic()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
    }
}
