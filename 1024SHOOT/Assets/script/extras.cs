using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class extras : MonoBehaviour
{

    public GameObject extraPrefabi;
    public extras[] extrasElemanlari;
    public static GameObject seciliEleman;
    public Animator shopGo;
    public ParticleSystem shopEfekt;



    private money moneyX;



    public void Start()
    {
        shopGo = GameObject.FindObjectOfType<shop>().GetComponent<Animator>();
        extrasElemanlari = GameObject.FindObjectsOfType<extras>();
        GetComponent<SpriteRenderer>().color = Color.black;
        moneyX = GameObject.FindObjectOfType<money>();
    }
    private void Update()
    {
        shopGo = GameObject.FindObjectOfType<shop>().GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();

        if ((GetComponent<SpriteRenderer>().color == Color.black))
        {
            shopGo.SetTrigger("active 0");
            shopEfekt.Play();

        }

        if (GetComponent<SpriteRenderer>().color == Color.white)
        {
            if (name == "bomb")
            {

                GetComponent<SpriteRenderer>().color = Color.black;

                seciliEleman = extraPrefabi;
                if (seciliEleman.name == "bomb")
                {


                 seciliEleman.GetComponent<SpriteRenderer>().color = Color.white;


                }


                else
                {
                    seciliEleman = null;
                }
            }
            if (name == "yatay")
            {

                GetComponent<SpriteRenderer>().color = Color.black;

                seciliEleman = extraPrefabi;
                if (seciliEleman.name == "yatay")
                {
                    seciliEleman.GetComponent<SpriteRenderer>().color = Color.white;

                }


                else
                {
                    seciliEleman = null;
                }
            }

            if (name == "dikey")
            {

                GetComponent<SpriteRenderer>().color = Color.black;

                seciliEleman = extraPrefabi;
                if (seciliEleman.name == "dikey")
                {


                    seciliEleman.GetComponent<SpriteRenderer>().color = Color.white;



                }


                else
                {
                    seciliEleman = null;
                }
            }



        }
    



    }

    public void ParayiAzalt(int paraMiktari)
    {
     moneyX.paraAzalt(paraMiktari);
    }


    

}
