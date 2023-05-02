using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float reloadTime = 1;

    public float speed = 3;


    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(Shoot());
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0, 0, speed * 0.1f);
    }

    IEnumerator Shoot()
    {
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.position = transform.position;
        newBullet.transform.rotation = transform.rotation;
        yield return new WaitForSeconds(reloadTime);
        StartCoroutine(Shoot());
    }
}
