using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float knockback;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == GetComponentInParent<Transform>().gameObject) return;

        if (collision.gameObject.tag == "animal")
        {
            Knockback(collision.gameObject);
            Damage(collision.gameObject);
        }
    }

    void Knockback(GameObject obj)
    {
        obj.GetComponent<Animal>().Knockbacked(this.gameObject);
    }

    void Damage(GameObject obj)
    {
        obj.GetComponent<Animal>().LoseLife(damage);
    }
}
