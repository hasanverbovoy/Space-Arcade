using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    public float speed = 1f;
    public bool isMoving = true;

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }   
    }
}
