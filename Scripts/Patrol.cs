using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed = 3;
    public Transform left;
    public Transform right;
    public bool goLeft = true;
    // Update is called once per frame
    void Update()
    {
        if(goLeft == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }   
        if(goLeft == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if(transform.position.x < left.position.x)
        {
            goLeft = false;
        }
        if(transform.position.x > right.position.x)
        {
            goLeft = true;
        }
    }
}
