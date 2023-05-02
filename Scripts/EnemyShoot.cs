using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
public float speed = 4f;
    public GameObject enemyBullet;
    public float reloadTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reload());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    IEnumerator Reload()
    {
        GameObject Bullet = Instantiate(enemyBullet);
        Bullet.transform.position = transform.position;
        yield return new WaitForSeconds(reloadTime);
        StartCoroutine(Reload());
    } 
}
