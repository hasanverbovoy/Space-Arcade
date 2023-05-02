using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
public GameObject bulletPrefab;
    public float reloadTime = 1f;
    public bool readyShoot = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && readyShoot)
        {
            readyShoot = false;
            StartCoroutine(Reload());
        }
    }
    IEnumerator Reload()
    {
        GameObject Bullet = Instantiate(bulletPrefab);
        Bullet.transform.position = transform.position;
        yield return new WaitForSeconds(reloadTime);
        readyShoot = true;
    } 
}
