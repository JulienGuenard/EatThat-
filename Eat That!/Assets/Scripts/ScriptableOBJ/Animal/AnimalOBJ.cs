using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "AnimalOBJ", menuName = "EatThis!/Animal", order = 1)]
public class AnimalOBJ : ScriptableObject
{
    [Header("Life")]
    public float lifeMax;
    public float lifeDefense;
    public float lifeInvulTime;

    [Header("Movement")]
    public float speedAcc;
    public float speedMax;
    public MovementType speedMovement;
    public AimType speedAim;

    [Header("Knockback")]
    public float knockbackForce;
    public float knockbackTime;
    public float knockbackDefense;

    [Header("Art")]
    public Animator animalAnimator;
    public Animator attackAnimator;
    public Animator iconAnimator;

    //

    [Header("Loot")]
    public Rarity lootRarity;
    public float lootChances;

    [Header("EnemyApparition")]
    public float EapparitionChances;

    [Header("Effects")]
    public List<EffectOBJ> effectList;

    [Header("AnimalType")]
    public AnimalType animalType;

    [Header("Tooltip")]
    public string tooltipTitle;
    [TextArea] public string tooltipText;
    [TextArea] public string tooltipDescription;

    [Header("Audio")]
    public AudioClip SFXapparition;
    public AudioClip SFXdeath;
    public AudioClip SFXattack;
    public AudioClip SFXhurted;
    public AudioClip SFXwalk;
    public AudioClip SFXinventory;
}