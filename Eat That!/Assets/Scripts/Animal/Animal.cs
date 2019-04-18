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

    [HideInInspector] public bool isDeath;
   
    private Rigidbody2D rigid;

    [HideInInspector] public AnimalMovement animalMovement;
    [HideInInspector] public AnimalLife animalLife;
    [HideInInspector] public AnimalTooltip animalTooltip;
    [HideInInspector] public AnimalArt animalArt;
    [HideInInspector] public AnimalAudio animalAudio;
    [HideInInspector] public AnimalEffect animalEffect;
    [HideInInspector] public AnimalKnockback animalKnockback;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        lifeCur = lifeMax;
        isInvulnerable = false;
        isInvulnerableKnock = false;
        isDeath = false;

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

        ChooseAim();

        //Move();
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
