using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalKnockback : Animal
{

    public float invulnerabilityKnockTime;
    public float knockbackForce;
    private bool isInvulnerableKnock;

    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();

        isInvulnerableKnock = false;
    }

    public void Knockbacked(GameObject obj)
    {
        if (isInvulnerableKnock) return;

        StartCoroutine(InvulnerabilityKnockback());

        Vector2 pos = -(obj.transform.position - transform.position) * knockbackForce;
        rigid.AddForce(pos);
    }

    IEnumerator InvulnerabilityKnockback()
    {
        isInvulnerableKnock = true;
        yield return new WaitForSeconds(invulnerabilityKnockTime);
        isInvulnerableKnock = false;
    }
}
