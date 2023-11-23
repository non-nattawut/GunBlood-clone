using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public string who_shoot = "";

    private float speed = 6f;

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * speed; // bullet move
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
