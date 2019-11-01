using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;
    public Vector2 v = Vector2.zero;
    Rigidbody2D myRigidbody;



    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        v = Vector2.zero;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v += Vector2.right;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            v += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v += Vector2.down;
        }
        v.Normalize();

        myRigidbody.position += v * speed * Time.fixedDeltaTime;
    }
}