using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBullet : MonoBehaviour
{

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Boss"))
        {
            HP bossHP = collision.gameObject.GetComponent<HP>();
            bossHP.Damage(1);
            Destroy(gameObject);
            if(bossHP.hp<=0)
            {
                SceneManager.LoadScene(3);
            }
        }
    } 
}
