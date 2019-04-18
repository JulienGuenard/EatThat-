using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalLife : Animal
{

    public float lifeMax;
    private float lifeCur;

    public float invulnerabilityTime;
    private bool isInvulnerable;

  /*  private void Awake()
    {
        lifeCur = lifeMax;
        isInvulnerable = false;
    }*/

    public void LoseLife(float value)
    {
        SetupVars();

        if (isInvulnerable) return;

        StartCoroutine(Invulnerability());

        lifeCur -= value;
        if (lifeCur < 1)
        {
            Death();
        }
    }

    IEnumerator Invulnerability()
    {
        isInvulnerable = true;
        yield return new WaitForSeconds(invulnerabilityTime);
        isInvulnerable = false;
    }

    private void Death()
    {
        isDeath = true;
        gameObject.SetActive(false);
    }
}
