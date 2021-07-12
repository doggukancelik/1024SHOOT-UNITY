using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topPozisyonu : MonoBehaviour
{
    public GameObject circle;
    void Start()
    {
        Instantiate(circle, transform.position, Quaternion.identity);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.3f);
    }
}
