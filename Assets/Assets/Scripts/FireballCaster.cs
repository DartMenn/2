using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
    public Fireball fireballPrefab;
    public float spawnInterval = 0.5f;

    void Start()
    {
        StartCoroutine(SpawnFireballs());
    }

    IEnumerator SpawnFireballs()
    {
        while (true)
        {
            Instantiate(fireballPrefab, transform.position, transform.rotation);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}