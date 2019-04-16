using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "EnemyGroupOBJ", menuName = "EatThis!/EnemyGroup", order = 1)]
public class EnemyGroupOBJ : ScriptableObject
{
    [Header("Animals")]
    public List<AnimalOBJ> availableAnimalList;
    public AnimalOBJ animalBoss;
    public float numberMin;
    public float numberMax;
    public Formation formation;

    [Header("Item Used")]
    public List<ItemOBJ> itemUsed;

    [Header("Rarity")]
    public float SpawnApparition;

    [Header("Loots")]
    public float lootBooster;
    public List<ItemOBJ> itemsGiven;

    [Header("Dialogue")]
    [TextArea] public List<string> dialogueIntro;
    [TextArea] public List<string> dialogueLose;
    [TextArea] public List<string> dialogueVictory;

    [Header("Tooltip")]
    [TextArea] public string tooltipTitle;
    [TextArea] public string tooltipStats;
    [TextArea] public string tooltipDescription;

    [Header("Audio")]
    public AudioClip music;
}