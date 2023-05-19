using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    Rigidbody2D myRigidbody;
    private float aliveTime = 15.0f; // time before object is destroyed
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        Destroy(gameObject, aliveTime);
    }

   
    void Update()
    {
        myRigidbody.velocity = new Vector2 (moveSpeed, 0f);
    }
}
