using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "AttackOBJ", menuName = "EatThis!/Attack", order = 1)]
public class AttackOBJ : ScriptableObject
{
    [Header("Attack")]
    public float attack;

    [Header("Knockback")]
    public float knockback;

    [Header("Effect")]
    public List<EffectOBJ> effectOBJlist;

    [Header("Cooldown")]
    public float cooldown;

    [Header("Prefab")]
    public GameObject prefab;

    [Header("AttackTrigger")]
    public float attackRange;

    [Header("Audio")]
    public AudioClip attackSound;
}