using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject rotateGun;

    public bool isAttacking = false;

    public GameObject laserPrepare;

    public GameObject laser;

    // Update is called once per frame
    void Update()
    {
        if(isAttacking == false)
        {
            isAttacking = true;
            Attack();
        }
    }
    
    void Attack()
    {
        int r = Random.Range(1, 3);
        if (r == 1)
        {
            StartCoroutine(AttackLaser());
        }
        if (r == 2)
        {
            StartCoroutine(AttackRotate());
        }
    }

    IEnumerator AttackRotate()
    {
        rotateGun.SetActive(true);
        yield return new WaitForSeconds(3);
        rotateGun.SetActive(false);
        yield return new WaitForSeconds(3);
        isAttacking = false;
    }

    IEnumerator AttackLaser()
    {
        laserPrepare.SetActive(true);
        yield return new WaitForSeconds(1);
        laserPrepare.SetActive(false);
        laser.SetActive(true);
        yield return new WaitForSeconds(2);
        laser.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = false;
        
    }
}
