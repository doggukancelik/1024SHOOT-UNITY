using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class topunOlusumu : MonoBehaviour
{

    public GameObject[] ballsPrefab;
    public GameObject iki;
    public GameObject dort;
    public GameObject sekiz;
    public GameObject on;
    public GameObject otuz;
    public GameObject altmis;
    public GameObject yuz;
    public GameObject ikiYuz;
    public GameObject besYuz;
    public GameObject bin;
    public GameObject ikibin;
    public GameObject dortbin;
    public GameObject sekizbin;
    public GameObject onbin;
    public GameObject otuzbin;
    public GameObject altmisbin;
    public GameObject yuzbin;

    public int RandomBallNumber;

    public int puan;
    public int skor;



    public int num;


    void Start()
    {
        num = ballsPrefab.Length;
        ballsPrefab = new GameObject[num];
        ballsPrefab[0] = iki as GameObject ;
        ballsPrefab[1] = dort as GameObject ;
        ballsPrefab[2] = sekiz as GameObject;
        ballsPrefab[3] = on as GameObject;
        ballsPrefab[4] = otuz as GameObject;
        ballsPrefab[5] = altmis as GameObject;
        ballsPrefab[6] = yuz as GameObject;
        ballsPrefab[7] = ikiYuz as GameObject;
        ballsPrefab[8] = besYuz as GameObject;
        ballsPrefab[9] = bin as GameObject;
        ballsPrefab[10] = ikibin as GameObject;
        ballsPrefab[11] = dortbin as GameObject;
        ballsPrefab[12] = sekizbin as GameObject;
        ballsPrefab[13] = onbin as GameObject;
        ballsPrefab[14] = otuzbin as GameObject;
        ballsPrefab[15] = altmisbin as GameObject;
        ballsPrefab[16] = yuzbin as GameObject;
        skor = collisonForBalls.skor;
       

    }
    void tektekCikis()
    {
        Transform uygunPozisyon = sonrakiUygunPozisyon();
        if (uygunPozisyon)
        {
            randomSelect();
        }

        if (sonrakiUygunPozisyon())
        {
            Invoke("tektekCikis",2f);//look

        }
    }


    //public void randomSelectFirst()
    //{
    //    int RandomBallNumber = Random.Range(0, num);

    //    foreach (Transform cocuk in transform)
    //    {
           
    //          GameObject ball = Instantiate(ballsPrefab[RandomBallNumber], cocuk.transform.position, Quaternion.identity) as GameObject;
    //          ball.transform.parent = cocuk;
                
    //    }
    //}


    // Update is called once per frame

    void Update()
    {
        //if (butunTopYokOL())
        //{
        //   tektekCikis();
        //}
        skor = collisonForBalls.skor;


    }

    public Transform sonrakiUygunPozisyon()
    {
        foreach (Transform cocukPozisyonu in transform)
        {
            if (cocukPozisyonu.childCount == 0)
            {
                return cocukPozisyonu;
            }


        }
        return null;
    }

    bool butunTopYokOL() // top var mı yok mu ?
    {
        foreach (Transform cocukPozisyonu in transform)
        {
            if (cocukPozisyonu.childCount > 0)
            {
                return false;
            }
        }
        return true;
    }

    public GameObject randomSelect()
    {
        if (skor >= 0 && skor < 50)
        {
            RandomBallNumber = Random.Range(0, 3);

        }
        else if (skor >= 50 && skor < 250)
        {
            RandomBallNumber = Random.Range(1, 5);

        }
        else if (skor >= 250 && skor < 1000)
        {
            RandomBallNumber = Random.Range(2, 7);

        }
        else if (skor >= 1000 && skor < 3000)
        {
            RandomBallNumber = Random.Range(3, 8);

        }
        else if (skor >= 3000 && skor < 7000)
        {
            RandomBallNumber = Random.Range(4, 9);

        }
        else if (skor >= 7000 && skor < 15000)
        {
            RandomBallNumber = Random.Range(5, 10);

        }
        else if (skor >= 15000 && skor < 30000)
        {
            RandomBallNumber = Random.Range(6, 11);

        }
        else if (skor >= 30000 && skor < 50000)
        {
            RandomBallNumber = Random.Range(7, 12);

        }
        else if (skor >= 50000 && skor < 75000)
        {
            RandomBallNumber = Random.Range(7, 13);

        }
        else if (skor >= 75000 && skor < 110000)
        {
            RandomBallNumber = Random.Range(8, 13);

        }
        else if (skor >= 110000 && skor < 145000)
        {
            RandomBallNumber = Random.Range(8, 14);

        }
        else if (skor >= 145000 && skor < 190000)
        {
            RandomBallNumber = Random.Range(9, 14);

        }
        else if (skor >= 190000 && skor < 230000)
        {
            RandomBallNumber = Random.Range(7, 17);

        }


        


        GameObject ball = Instantiate(ballsPrefab[RandomBallNumber], sonrakiUygunPozisyon().transform.position, Quaternion.identity) as GameObject;
        ball.transform.parent = sonrakiUygunPozisyon();
        return ball;

    }
    
   
}
