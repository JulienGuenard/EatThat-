using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "EffectOBJ", menuName = "EatThis!/Effect", order = 1)]
public class EffectOBJ : ScriptableObject
{
    public float effectMultiplier;

    public Sprite icon;
    public GameObject prefabFX;
}