using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public int hp = 30;

    public void Damage(int damage)
    {
        hp -= damage;
        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }
}
