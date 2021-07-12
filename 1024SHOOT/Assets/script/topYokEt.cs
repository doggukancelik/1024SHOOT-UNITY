using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topYokEt : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollision2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
