using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : Animal
{
    private bool noMoreAim = false;
    private Animal aim;

    private Vector2 speedCur;

    private Rigidbody2D rigid;

    private void Awake()
    {
        noMoreAim = false;
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }

    public void ChooseAim()
    {
        if (noMoreAim) return;

        if (aim && !aim.isDeath) return;

        foreach (Animal obj in FindObjectsOfType<Animal>())
        {
            if (!obj.isDeath && obj != this && obj.owner != owner)
            {
                aim = obj;
                return;
            }

        }

        noMoreAim = true;

    }

    public void Move()
    {
        Vector2 aimPos = Vector2.ClampMagnitude(transform.position - transform.position, speed);

        if (aim)
            aimPos = Vector2.ClampMagnitude(aim.transform.position - transform.position, speed);

        speedCur += aimPos;

        speedCur = Vector2.ClampMagnitude(speedCur, speedMax);

        rigid.velocity = speedCur;
    }
}
