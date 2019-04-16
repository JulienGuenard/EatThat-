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

    public float speed;
    private Animal aim;
    private bool noMoreAim;
    private Vector2 speedCur;
    public float speedMax;

    public float lifeMax;
    private float lifeCur;

    public float invulnerabilityTime;
    private bool isInvulnerable;

    public float invulnerabilityKnockTime;
    public float knockbackForce;
    private bool isInvulnerableKnock;

    private bool isDeath;
   
    private Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        lifeCur = lifeMax;
        isInvulnerable = false;
        isInvulnerableKnock = false;
        isDeath = false;
        noMoreAim = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeath) return;

        ChooseAim();

        Move();
    }

    void ChooseAim()
    {
        if (noMoreAim) return;

        if (aim && !aim.isDeath) return;

        foreach(Animal obj in FindObjectsOfType<Animal>())
        {
            if (!obj.isDeath && obj != this && obj.owner != owner)
            {
                aim = obj;
                return;
            }
          
        }

        noMoreAim = true;

    }

    void Move()
    {
        Vector2 aimPos = Vector2.ClampMagnitude(transform.position - transform.position, speed);

        if (aim)
            aimPos = Vector2.ClampMagnitude(aim.transform.position - transform.position, speed);

        speedCur += aimPos;

        speedCur = Vector2.ClampMagnitude(speedCur, speedMax);

        

        rigid.velocity = speedCur;
    }

    public void LoseLife(float value)
    {
        if (isInvulnerable) return;

        StartCoroutine(Invulnerability());

        lifeCur -= value;
        if (lifeCur < 1)
        {
            Death();
        }
    }

    public void Knockbacked(GameObject obj)
    {
        if (isInvulnerableKnock) return;

        StartCoroutine(InvulnerabilityKnockback());

        Vector2 pos = -(obj.transform.position - transform.position) * knockbackForce;
        rigid.AddForce(pos);
    }

    IEnumerator Invulnerability()
    {
        isInvulnerable = true;
        yield return new WaitForSeconds(invulnerabilityTime);
        isInvulnerable = false;
    }

    IEnumerator InvulnerabilityKnockback()
    {
        isInvulnerableKnock = true;
        yield return new WaitForSeconds(invulnerabilityKnockTime);
        isInvulnerableKnock = false;
    }

    private void Death()
    {
        isDeath = true;
        gameObject.SetActive(false);
    }
}
