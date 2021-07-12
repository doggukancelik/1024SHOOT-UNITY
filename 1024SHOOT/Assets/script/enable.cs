using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enable : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.y > -3f)
            {
                GameObject.FindObjectOfType<extras>().enabled = false;
                Debug.Log("yukari");
                GameObject.FindObjectOfType<ballDirection>().enabled = true;
              
            }
            else if (mousePos.y < -3f)
            {
                GameObject.FindObjectOfType<ballDirection>().enabled = false;

                GameObject.FindObjectOfType<extras>().enabled = true;
                Debug.Log("aşağı");
            }
        }
    }
}
