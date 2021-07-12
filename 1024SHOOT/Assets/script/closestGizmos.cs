using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closestGizmos : MonoBehaviour
{
    Vector3 closestPoint;
    Vector3 closestxPoint;
    public GameObject[] taggedObjects;
    public GameObject[] taggedObjectsx;
    public topunOlusumu top;


    void Start()
    {
        top = GameObject.FindObjectOfType<topunOlusumu>();

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    void FixedUpdate()
    {
        top = GameObject.FindObjectOfType<topunOlusumu>();

        if ((!(gameObject.transform.position == new Vector3(0, -3, 0)) && (gameObject.GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))))
        {

            closeX("gizmos");
        }

    }

    public void closeX(string tagName)
    {
 
        GameObject[] taggedObjects;
        taggedObjects = GameObject.FindGameObjectsWithTag(tagName);
        closestPoint = new Vector3(0f, 0f, 0f);
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject go in taggedObjects)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closestPoint = go.transform.position;
                distance = curDistance;
                gameObject.transform.position = closestPoint;
                //look...
                if (go.transform.childCount == 0)
                {
                    if (gameObject.transform.position == closestPoint)
                    {
                        gameObject.transform.parent = go.transform;
                    }
                }
            }
           
        }


    }
    public void closeXx(string tagName)
    {
        GameObject[] taggedObjectsx;
        taggedObjectsx = GameObject.FindGameObjectsWithTag(tagName);
        closestxPoint = new Vector3(0f, 0f, 0f);
        float distancex = Mathf.Infinity;
        Vector3 position = transform.position;

        foreach (GameObject gox in taggedObjectsx)
        {
            Vector3 diffx = gox.transform.position - position;
            float curDistancex = diffx.sqrMagnitude;
            if (curDistancex < distancex)
            {
                closestxPoint = gox.transform.position;
                distancex = curDistancex;
                gameObject.transform.position = closestxPoint;
                //look...
                if (gox.transform.childCount == 0)
                {
                    if (gameObject.transform.position == closestxPoint)
                    {
                        gameObject.transform.parent = gox.transform;
                    }
                

                }
            }
        }
    }



}
