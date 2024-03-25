﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float maxSize = 5;
    public float speed = 5;
    public float damage = 50;

    private void Start()
    {
        transform.localScale = Vector3.zero;
    }
    private void Update()
    {
        transform.localScale += Vector3.one * Time.deltaTime * speed;

        if (transform.localScale.x > maxSize)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var Health = other.GetComponent<Health>();
        if (Health != null)
        {
            Health.GetDamage(damage);
        }
    }
}