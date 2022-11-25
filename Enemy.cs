using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Player;
    float speed = 5f;
    Rigidbody rigidBoody;
    void Start()
    {
        rigidBoody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Player != null)
        {
            Vector3 position = Vector3.MoveTowards(transform.position, Player.position, speed * Time.fixedDeltaTime);
            rigidBoody.MovePosition(position);
            transform.LookAt(Player);
        }       
    }
}
