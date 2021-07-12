using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmoSilici : MonoBehaviour
{
    #region yataySutun
    public GameObject[] yatay1;
    public GameObject[] yatay2;
    public GameObject[] yatay3;
    public GameObject[] yatay4;
    public GameObject[] yatay5;
    #endregion

    #region dikeySutun
    public GameObject[] dikey1;
    public GameObject[] dikey2;
    public GameObject[] dikey3;
    public GameObject[] dikey4;
    public GameObject[] dikey5;
    public GameObject[] dikey6;
    public GameObject[] dikey7;
    #endregion


    #region Gizmolar
    public GameObject gizmo1;
    public GameObject gizmo2;
    public GameObject gizmo3;
    public GameObject gizmo4;
    public GameObject gizmo5;
    public GameObject gizmo6;
    public GameObject gizmo7;
    public GameObject gizmo8;
    public GameObject gizmo9;
    public GameObject gizmo10;
    public GameObject gizmo11;
    public GameObject gizmo12;
    public GameObject gizmo13;
    public GameObject gizmo14;
    public GameObject gizmo15;
    public GameObject gizmo16;
    public GameObject gizmo17;
    public GameObject gizmo18;
    public GameObject gizmo19;
    public GameObject gizmo20;
    public GameObject gizmo21;
    public GameObject gizmo22;
    public GameObject gizmo23;
    public GameObject gizmo24;
    public GameObject gizmo25;
    public GameObject gizmo26;
    public GameObject gizmo27;
    public GameObject gizmo28;
    public GameObject gizmo29;
    public GameObject gizmo30;
    public GameObject gizmo31;
    public GameObject gizmo32;
    public GameObject gizmo33;
    public GameObject gizmo34;
    public GameObject gizmo35;
    #endregion

    //public GameObject bomb;
    //public GameObject yatay;
    //public GameObject dikey;



    public extrasMekan transformke;


    public ParticleSystem dikeyEfekt;
    public ParticleSystem yatayEfekt;


    public AudioClip silmeSesi;

    void Start()
    {

        transformke = GameObject.FindObjectOfType<extrasMekan>();

        
    }

    // Update is called once per frame
    void Update()
    {
    

        transformke = GameObject.FindObjectOfType<extrasMekan>();
        


    }
//    public void yatayBos(GameObject[] yatayx1, GameObject[] yatayx2)
//    {
//        foreach (GameObject gizmo in yatayx1)
//        {
//            if (gizmo.transform.childCount == 0)
//            {
//                foreach (Transform child in gizmo.transform)
//                {
//                    foreach (GameObject gizmox in yatayx2)
//                    {
//                        if (gizmox.transform.childCount >= 0)
//                        {
//                            foreach (Transform childx in gizmox.transform)
//                            {
//                                //noktayı koy;
//                                //gizmo.transform.child.position.y = childx.position.y

//;
//                            }
//                        }
//                    }

//                }
//            }



//        }
//    }
    #region yataySilen
    public void yataySilen(Vector2 yatay)
        {
        if (transformke.fareDunya().y >= 3f && transformke.fareDunya().y < 3.67f)
        {
            yatayEfekt.GetComponent<Transform>().transform.position = new Vector3(0f, 3.35f, 0f);

            foreach (GameObject gizmo in yatay1)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);

                    }
                }
             
            }
            yatayEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }

        else if (transformke.fareDunya().y >= 2.3f && transformke.fareDunya().y < 3f)
        {
            yatayEfekt.GetComponent<Transform>().transform.position = new Vector3(0f, 2.65f, 0f);
            foreach (GameObject gizmo in yatay2)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
               
                    }
                }
            }
            yatayEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);

        }
        else if (transformke.fareDunya().y >= 1.6f && transformke.fareDunya().y < 2.3f)
        {
            yatayEfekt.GetComponent<Transform>().transform.position = new Vector3(0f, 1.95f, 0f);
            foreach (GameObject gizmo in yatay3)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                       
                    }
                }
            }
            yatayEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        else if (transformke.fareDunya().y >= 0.9f && transformke.fareDunya().y < 1.6f)
        {
            yatayEfekt.GetComponent<Transform>().transform.position = new Vector3(0f, 1.25f, 0f);
            foreach (GameObject gizmo in yatay4)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
          
                    }
                }
            }
            yatayEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        else if (transformke.fareDunya().y >= 0.15f && transformke.fareDunya().y < 0.9f)
        {
            yatayEfekt.GetComponent<Transform>().transform.position = new Vector3(0f, 0.55f, 0f);

            foreach (GameObject gizmo in yatay5)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    
                    }
                }
            }
        }
        yatayEfekt.Play();
        AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


    }
    #endregion


    #region dikeySilen
    public void dikeySilen(Vector2 dikey)
    {
        if (transformke.fareDunya().x >= -2.55f && transformke.fareDunya().x < -1.78f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(-2.136f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey1)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            dikeyEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }

        if (transformke.fareDunya().x >= -1.78f && transformke.fareDunya().x < -1.07f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(-1.424f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey2)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            dikeyEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        if (transformke.fareDunya().x >= -1.07f && transformke.fareDunya().x < -0.355f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(-0.712f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey3)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);


                    }
                }
            }
            dikeyEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        if (transformke.fareDunya().x >= -0.355f && transformke.fareDunya().x < 0.355f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(0f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey4)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    }

                }
            }
            dikeyEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        if (transformke.fareDunya().x >= 0.355f && transformke.fareDunya().x < 1.07f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(0.712f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey5)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            dikeyEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        if (transformke.fareDunya().x >= 1.07f && transformke.fareDunya().x < 1.78f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(1.424f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey6)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
            dikeyEfekt.Play();
            AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


        }
        if (transformke.fareDunya().x >= 1.78f && transformke.fareDunya().x < 2.55f)
        {
            dikeyEfekt.GetComponent<Transform>().transform.position = new Vector3(2.136f, 1.88f, 0f);

            foreach (GameObject gizmo in dikey7)
            {
                if (gizmo.transform.childCount > 0)
                {
                    foreach (Transform child in gizmo.transform)
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
        }
        dikeyEfekt.Play();
        AudioSource.PlayClipAtPoint(silmeSesi, transform.position);


    }
    #endregion       

    #region bombSilen
    public void bombSilen(Vector2 bomb)
    {
        yataySilen(bomb);
        dikeySilen(bomb);
    }
    #endregion            // bomb


}
