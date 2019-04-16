using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ZoneOBJ", menuName = "EatThis!/Zone", order = 1)]
public class ZoneOBJ : ScriptableObject
{
    [Header("Zone")]
    public ZoneType zoneType;

    [Header("Enemy Group")]
    public List<EnemyGroupOBJ> enemyGroupList;
    public float enemyGroupNumber;

    [Header("Event Group")]
    public List<EventOBJ> eventList;
    public float eventNumber;

    [Header("Audio")]
    public AudioClip music;
}