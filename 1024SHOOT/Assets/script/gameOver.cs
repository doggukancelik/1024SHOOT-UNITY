using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{

    public GameObject panel;

    public GameObject gizmo1;
    public GameObject gizmo2;
    public GameObject gizmo3;
    public GameObject gizmo4;
    public GameObject gizmo5;
    public GameObject gizmo6;
    public GameObject gizmo7;
    public GameObject[] gizmoList;
    public int num;

    public GameObject panelAll;
    public GameObject elli;
    public GameObject otuz;
    public GameObject yirmi;
    public GameObject shop;
    public GameObject pause;

    public Text skor;
    void Start()
    {
        panel.SetActive(false);

        num = gizmoList.Length;
        gizmoList = new GameObject[num];
        gizmoList[0] = gizmo1;
        gizmoList[1] = gizmo2;
        gizmoList[2] = gizmo3;
        gizmoList[3] = gizmo4;
        gizmoList[4] = gizmo5;
        gizmoList[5] = gizmo6;
        gizmoList[6] = gizmo7;
    }

    // Update is called once per frame
    void Update()
    {
  

        foreach (GameObject gizmo in gizmoList)
        {
            if (gizmo.transform.childCount > 0)
            {
                panelAll.SetActive(true);
                panel.SetActive(true);
                Time.timeScale = 0f;
                skor.text = collisonForBalls.skor.ToString();

            }
        }
        if (panel.activeSelf==true)
        {
            elli.SetActive(false);
            otuz.SetActive(false);
            yirmi.SetActive(false);
            shop.SetActive(false);
            pause.SetActive(false);

        }

    }

   




}
