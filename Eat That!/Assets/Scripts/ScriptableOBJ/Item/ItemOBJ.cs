using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ItemOBJ", menuName = "EatThis!/Item", order = 1)]
public class ItemOBJ : ScriptableObject
{
    [Header("Life Modifier")]
    public float lifeModifier;
    public float lifeDefense;
    public float lifeInvulTime;

    [Header("Movement Modifier")]
    public float speedModifier;
    public float speedMax;
    public MovementType speedMovement;
    public AimType speedAim;


    [Header("Knockback Modifier")]
    public float knockbackForce;
    public float knockbackTime;
    public float knockbackDefense;

    [Header("Art Modifier")]
    public Animator animalAnimator;
    public Animator attackAnimator;
    public Animator iconAnimator;

    //

    [Header("Loot Modifier")]
    public float lootChancesModifier;

    [Header("EnemyApparition Modifier")]
    public float EapparitionChances;

    [Header("Effects Modifier")]
    public List<EffectOBJ> effectList;

    [Header("Animal Type Affect")]
    public AnimalType animalType;

    [Header("Tooltip")]
    public string tooltipTitle;
    [TextArea] public string tooltipText;
    [TextArea] public string tooltipDescription;

    //

    [Header("Inventory Modifier")]
    public float inventorySpace;

    [Header("Loot")]
    public float lootChances;

    [Header("FX")]
    public GameObject fxPrefab;
    public FXhappening fxHappening;

    [Header("Audio")]
    public AudioClip SFXapparition;
    public AudioClip SFXinventory;
}