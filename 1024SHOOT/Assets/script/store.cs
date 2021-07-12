using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour
{
    public money moneyX;
    //public money para;



    public GameObject bomb; 
    public GameObject yatay; 
    public GameObject dikey;
    public extras extra;
   


    public void Start()
    {
        moneyX = GameObject.FindObjectOfType<money>();
        bomb = GameObject.FindGameObjectWithTag("bomb");        
        yatay = GameObject.FindGameObjectWithTag("yatay");        
        dikey = GameObject.FindGameObjectWithTag("dikey");
    }
    private void Update()
    {
        bomb = GameObject.FindGameObjectWithTag("bomb");
        yatay = GameObject.FindGameObjectWithTag("yatay");
        dikey = GameObject.FindGameObjectWithTag("dikey");
    }

    public void bombaAl()
    {
        int coins = PlayerPrefs.GetInt("Coins");

        if (coins > 0)
        {
            if (bomb.GetComponent<SpriteRenderer>().color == Color.black)
            {
                if ((coins >= 50))
                {
                    ParayiAzalt(50);
                    bomb.GetComponent<SpriteRenderer>().color = Color.white;

                }
                else
                {
                    ParayiAzalt(0);
                }
            }
          
        }   
    }

    public void yatayAl()
    {
        int coins = PlayerPrefs.GetInt("Coins");

        if (coins > 0)
        {
            if (yatay.GetComponent<SpriteRenderer>().color == Color.black)
            {
                if (coins >= 30)
                {
                    ParayiAzalt(30);
                    yatay.GetComponent<SpriteRenderer>().color = Color.white;

                }
                else
                {

                    ParayiAzalt(0);
                }
            }

        }
    }
    public void dikeyAl()
    {
        int coins = PlayerPrefs.GetInt("Coins");

        if (coins > 0)
        {
            if (dikey.GetComponent<SpriteRenderer>().color == Color.black)
            {
                if (coins >= 20)
                {
                    ParayiAzalt(20);
                    dikey.GetComponent<SpriteRenderer>().color = Color.white;

                }
                else
                {

                    ParayiAzalt(0);
                }
            }

        }
    }



    public void ParayiAzalt(int paraMiktari)
    {
        moneyX.paraAzalt(paraMiktari);
    }
    public void ParayiArttir(int paraMiktari)
    {
        moneyX.paraArrtir(paraMiktari);
    }
}
