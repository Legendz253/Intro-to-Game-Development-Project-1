using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonouSlime : MonoBehaviour
{
    public GameObject explosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 particleSpawnPoint = other.transform.position;
        Instantiate(explosionEffect, particleSpawnPoint, Quaternion.identity);

        Destroy(other.gameObject);
    }
}
