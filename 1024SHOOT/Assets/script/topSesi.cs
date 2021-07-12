using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topSesi : MonoBehaviour
{
    public AudioClip ses;

    private void Start()
    {
        if (gameObject.transform.position.y < 0f)
        {
            AudioSource.PlayClipAtPoint(ses, transform.position);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="wall")
        {
            if (gameObject != null)
            {
                AudioSource.PlayClipAtPoint(ses, collision.transform.position);

            }
        }

    }
}
