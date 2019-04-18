using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public enum Owner
        {
        Red,
        Blue
        }

    public Owner owner;



    [HideInInspector] public bool isDeath;
   
    private Rigidbody2D rigid;

    [HideInInspector] public AnimalMovement animalMovement;
    [HideInInspector] public AnimalLife animalLife;
    [HideInInspector] public AnimalTooltip animalTooltip;
    [HideInInspector] public AnimalArt animalArt;
    [HideInInspector] public AnimalAudio animalAudio;
    [HideInInspector] public AnimalEffect animalEffect;
    [HideInInspector] public AnimalKnockback animalKnockback;

    private void Awake()
    {
        isDeath = false;
        SetupVars();
    }

    public void SetupVars()
    {
        rigid = GetComponent<Rigidbody2D>();

        animalMovement = GetComponent<AnimalMovement>();
        animalLife = GetComponent<AnimalLife>();
        animalTooltip = GetComponent<AnimalTooltip>();
        animalArt = GetComponent<AnimalArt>();
        animalAudio = GetComponent<AnimalAudio>();
        animalEffect = GetComponent<AnimalEffect>();
        animalKnockback = GetComponent<AnimalKnockback>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeath) return;

        animalMovement.ChooseAim();
        animalMovement.Move();
    }








}
