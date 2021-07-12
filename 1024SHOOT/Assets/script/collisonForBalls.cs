using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class collisonForBalls : MonoBehaviour
{
    public GameObject iki;
    public GameObject dort;
    public GameObject sekiz;
    public GameObject onalti;
    public GameObject otuz;
    public GameObject altmis;
    public GameObject yuz;
    public GameObject ikiYuz;
    public GameObject besYuz;
    public GameObject bin;
    public GameObject ikiBin;
    public GameObject dortBin;
    public GameObject sekizBin;
    public GameObject onaltiBin;
    public GameObject otuzikiBin;
    public GameObject altmisdortBin;
    public GameObject yuzBin;
    public GameObject sonsuz;
    public Text skorum;
    public static int skor;
    
    public Text bonusText;

    public Rigidbody2D rbd2;




    private void Start()
    {
        bonusText = GameObject.FindGameObjectWithTag("tebrik").GetComponent<Text>();
        rbd2 = gameObject.GetComponent<Rigidbody2D>();
        skorum =GameObject.FindGameObjectWithTag("skor").GetComponent<Text>();
        skorum.text = skor.ToString();

    }
    private void Update()
    {

        skorum.text = skor.ToString();
        if (skor > playerPrefs.highPrefs())
        {
            playerPrefs.highScore(skor);
            playerPrefs.highPrefs();
        }


    }
    void FixedUpdate()
    {

        if ( rbd2.bodyType== RigidbodyType2D.Kinematic)           ///noke
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;      //18/12//2020
            
            rbd2.useFullKinematicContacts = true;
        }


    }

    private void OnCollisionStay2D(Collision2D collision)                     //2812
    {
        if (gameObject != null)
        {
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), collision.gameObject.GetComponent<Collider2D>());
        }
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {

        rbd2 = gameObject.GetComponent<Rigidbody2D>();


        if (gameObject.CompareTag("iki"))
        {
            if (collision.gameObject.CompareTag("iki"))        
            {

                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                    skor += 2;

                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y|| collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(dort, collision.gameObject.transform.position, Quaternion.identity);

                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(dort, gameObject.transform.position, Quaternion.identity);

                    }

                    Destroy(collision.gameObject);
                    Destroy(gameObject);


                }
            }

            else if(!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("iki")) && !(collision.gameObject.CompareTag("wall")))
            {

                rbd2.bodyType = RigidbodyType2D.Kinematic;

            }
        }



        if (gameObject.CompareTag("dort"))
        {
            if (collision.gameObject.CompareTag("dort"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                    skor += 4;

                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(sekiz, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(sekiz, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("dort")) && !(collision.gameObject.CompareTag("wall")))
            {

                rbd2.bodyType = RigidbodyType2D.Kinematic;

            }
        }



        if (gameObject.CompareTag("sekiz"))
        {
            if (collision.gameObject.CompareTag("sekiz"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                    skor += 8;


                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(onalti, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(onalti, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("sekiz")) && !(collision.gameObject.CompareTag("wall")))
            {

                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("onAlti"))
        {
            if (collision.gameObject.CompareTag("onAlti"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                    skor += 16;


                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(otuz, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(otuz, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("onAlti")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("otuzIki"))
        {
            if (collision.gameObject.CompareTag("otuzIki"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                    skor += 32;

                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(altmis, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(altmis, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("otuzIki")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("altmisDort"))
        {
            if (collision.gameObject.CompareTag("altmisDort"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                    skor += 64;

                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(yuz, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if(collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(yuz, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);

                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("altmisDort")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }
        if (gameObject.CompareTag("yuzYirmiSekiz"))
        {
            if (collision.gameObject.CompareTag("yuzYirmiSekiz"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {

                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(ikiYuz, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(ikiYuz, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 128;


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("yuzYirmiSekiz")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("ikiYuzElliAlti"))
        {
            if (collision.gameObject.CompareTag("ikiYuzElliAlti"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
            
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(besYuz, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(besYuz, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 256;


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("ikiYuzElliAlti")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("besYuz"))
        {
            if (collision.gameObject.CompareTag("besYuz"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                 
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(bin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(bin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 512;


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("besYuz")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }



        if (gameObject.CompareTag("bin"))
        {
            if (collision.gameObject.CompareTag("bin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
          
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(ikiBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(ikiBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 1024;


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("bin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }


        if (gameObject.CompareTag("ikiBin"))
        {
            if (collision.gameObject.CompareTag("ikiBin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
              
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(dortBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(dortBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 1024;
                    bonusText.text = "GOOD";


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("ikiBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }


        if (gameObject.CompareTag("dortBin"))
        {
            if (collision.gameObject.CompareTag("dortBin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                 
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(sekizBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(sekizBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 1024;


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("dortBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }


        if (gameObject.CompareTag("sekizBin"))
        {
            if (collision.gameObject.CompareTag("sekizBin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(onaltiBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(onaltiBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 1024;


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("sekizBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("onAltiBin"))
        {
            if (collision.gameObject.CompareTag("onAltiBin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                  
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(otuzikiBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(otuzikiBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 2048;

                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("onAltiBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("otuzIkiBin"))
        {
            if (collision.gameObject.CompareTag("otuzIkiBin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
             
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(altmisdortBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(altmisdortBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 2048;
                    bonusText.text = "GREAT";


                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("otuzIkiBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

        if (gameObject.CompareTag("altmisBin"))
        {
            if (collision.gameObject.CompareTag("altmisBin"))
            {
                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                 
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(yuzBin, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(yuzBin, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 4096;

                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("altmisBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }
        if (gameObject.CompareTag("yuzBin"))
        {
            if (collision.gameObject.CompareTag("yuzBin"))
            {

                if (collision.gameObject.GetInstanceID() > gameObject.GetInstanceID())
                {
                 
                    if (collision.gameObject.transform.position.y > gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(sonsuz, collision.gameObject.transform.position, Quaternion.identity);
                    }
                    else if (collision.gameObject.transform.position.y < gameObject.transform.position.y || collision.gameObject.transform.position.y == gameObject.transform.position.y)
                    {
                        Instantiate(sonsuz, gameObject.transform.position, Quaternion.identity);

                    }
                    Destroy(collision.gameObject);
                    Destroy(gameObject);
                    skor += 4096;
                    bonusText.text = "PERFECT";
                }
            }

            else if (!(collision.gameObject.CompareTag("background")) && !(collision.gameObject.CompareTag("yuzBin")) && !(collision.gameObject.CompareTag("wall")))
            {
                rbd2.velocity = new Vector3(0, 0, 0);
                rbd2.bodyType = RigidbodyType2D.Kinematic;
            }
        }

    }



}
