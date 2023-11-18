using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruibles : MonoBehaviour
{
    public float Resistencia;
    public GameObject explosionPrefab;

    void OnColisionEnter2D(Collision2D col)
    {
        if (col.relativeVelocity.magnitude > Resistencia)
        {
            if (explosionPrefab != null)
            {
                var go = Instantiate(explosionPrefab, transform.position, Quaternion.identity);

                Destroy(go, 3);
            }
            Destroy(gameObject, 0.1f);
           
        }
        else
        {
            Resistencia -= col.relativeVelocity.magnitude;
        }
    }
}
