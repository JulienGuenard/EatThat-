using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematic : MonoBehaviour
{
    public CinematicOBJ cinematicOBJ;
    public Dialogue dialogue;

    public float cinematicEndDelay;

    private int dialogueCur = -1;

    [HideInInspector] public AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        StartMusic();
        ReadDialogue();
    }

    public void ReadDialogue()
    {
        dialogueCur++;
        if (dialogueCur == cinematicOBJ.listDialogue.Count)
        {
            StartCoroutine(StopCinematic());
            return;
        }
        dialogue.ReadDialogue(cinematicOBJ.listDialogue[dialogueCur]);
        
    }

    private IEnumerator StopCinematic()
    {
        StopMusic();
        yield return new WaitForSeconds(cinematicEndDelay);
        SceneManager.LoadScene("FightPhase", LoadSceneMode.Single);
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
