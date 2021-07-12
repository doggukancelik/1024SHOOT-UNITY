using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ballDirection : MonoBehaviour
{
    public Vector3 firstBallPosition;
    public Vector3 secondtBallPosition;
    public Vector3 TempPosition;
    public List<GameObject> referenceList;
    public GameObject player;                  
    public GameObject ballReference;
    public float angelY;
    public float angelX;
    public float xPosition;
    public float yPosition;
    public bool isMoving = false;
    private Rigidbody2D rb2d;
    public float speed =15f;
    public int RandomBallNumber;
    public int skor;

    public GameObject[] ballsPrefab;
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

    public int num;
    public Text skorx;

    public GameObject touchPanel;
    public GameObject ogretici;



    public ParticleSystem dikeyEfekt;
    public ParticleSystem yatayEfekt;

    private void Start()
    {
        num = ballsPrefab.Length;
        ballsPrefab = new GameObject[num];
        ballsPrefab[0] = iki as GameObject;
        ballsPrefab[1] = dort as GameObject;
        ballsPrefab[2] = sekiz as GameObject;
        ballsPrefab[3] = onalti as GameObject;
        ballsPrefab[4] = otuz as GameObject;
        ballsPrefab[5] = altmis as GameObject;
        ballsPrefab[6] = yuz as GameObject;
        ballsPrefab[7] = ikiYuz as GameObject;
        ballsPrefab[8] = besYuz as GameObject;
        ballsPrefab[9] = bin as GameObject;
        ballsPrefab[10] = ikiBin as GameObject;
        ballsPrefab[11] = dortBin as GameObject;
        ballsPrefab[12] = sekizBin as GameObject;
        ballsPrefab[13] = onaltiBin as GameObject;
        ballsPrefab[14] = otuzikiBin as GameObject;
        ballsPrefab[15] = altmisdortBin as GameObject;
        ballsPrefab[16] = yuzBin as GameObject;
        skor = collisonForBalls.skor;
        
        if (SceneManager.GetActiveScene().name == "gamex")
        {
            Time.timeScale = 1f;
         
        }

        player = randomSelect() as GameObject;
        referenceList = new List<GameObject>();
        player.transform.position = new  Vector3(0,-3f, 0);
        spawn();
        PlayerControl(player);

    }

    public void spawn()
    {
        for (int i = 0; i < 35; i++)
        {
            GameObject spawn = Instantiate(ballReference, Vector3.zero, Quaternion.identity);
            spawn.name = "BallReference_" + i.ToString();

            referenceList.Add(spawn);
            spawn.SetActive(false);


        }
    }
    public void PlayerControl(GameObject playerObject)
    {
        firstBallPosition = new Vector3(0,-2.4f,0);
        TempPosition = firstBallPosition;
        player = playerObject;
        rb2d = player.GetComponent<Rigidbody2D>();
         
    }

    public bool OlduMux()
    {
        if (player == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool oyunaDevamMı()
    {
        if (player != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool topDogsun()
    {
        if (player.transform.position.y > -0.81f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    private void Update()
    {
        skor = collisonForBalls.skor;

        rb2d = player.GetComponent<Rigidbody2D>();

        if (OlduMux())
        {
            player = randomSelect();
            rb2d = player.GetComponent<Rigidbody2D>();
        }

        if (topDogsun())
        {
            player = randomSelect();
            rb2d = player.GetComponent<Rigidbody2D>();
            for (int i = 0; i < 35; i++)
            {
                referenceList[i].SetActive(false);

            }

        }

        if (dikeyEfekt.isPlaying == true || yatayEfekt.isPlaying == true)
        {
            isMoving = false;
        }



    }
    
    void FixedUpdate()             
    {

        if (Mathf.Abs(secondtBallPosition.y - TempPosition.y) > 0.00001f && Mathf.Abs(secondtBallPosition.x - TempPosition.x) > 0.00001f && oyunaDevamMı())
        {
            DirectionBall();
        }


        if (isMoving)
        {
            isMoving = false;
            speed = 15f;
            if ( player.transform.position.y > -0.81f)                  
            {
                speed = 0;                             
            }
            move(secondtBallPosition - firstBallPosition);

        }
        if (angelY < 0.40f)
        {
            for (int i = 0; i < 35; i++)
            {
                referenceList[i].SetActive(false);

            }
            speed = 0f;
            move(secondtBallPosition - firstBallPosition);

        }

    }
    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    private void OnMouseDown()                
    {
        touchPanel.SetActive(false);
        ogretici.SetActive(false);
        if (!IsPointerOverUIObject())
        {
            secondtBallPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            DirectionBall();
            isMoving = false;
        }


    }

    private void OnMouseDrag()
    {
        if (!IsPointerOverUIObject())
        {
            secondtBallPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            isMoving = false;
        }
        if (IsPointerOverUIObject())    
        {
            for (int i = 0; i < 35; i++)
            {
                referenceList[i].SetActive(false);
                isMoving = false;

            }
        }
    }



    private void OnMouseUp()
    {

        if (!IsPointerOverUIObject())
        {
            secondtBallPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (secondtBallPosition.y > -1.7f)
            {
                isMoving = true;
                for (int i = 0; i < 35; i++)
                {
                    referenceList[i].SetActive(false);
                }
            }
            if(secondtBallPosition.y < -1.7f)
            {
                isMoving = false;
                for (int i = 0; i < 35; i++)
                {
                    referenceList[i].SetActive(false);
                }
            }
         
        }
    }


    private void DirectionBall()
    {
        float angleRad = Mathf.Atan2((secondtBallPosition.y - firstBallPosition.y) - 0.2f  , (secondtBallPosition.x - firstBallPosition.x));
        angelX = Mathf.Cos(angleRad);
        angelY = Mathf.Sin(angleRad);
        xPosition = firstBallPosition.x;
        yPosition = firstBallPosition.y ;

        Ball();
        TempPosition = secondtBallPosition;
    }

    private void move(Vector2 force)
    {
        if (player.isStatic == true || player.transform.position.y > -0.81f)       
        {
            force = new Vector2(0, 0);
            speed = 0;                                                   
            rb2d.velocity = force.normalized * speed;                       
        }
        rb2d.velocity = force.normalized * speed;

      
    }


    public LayerMask mask;
    public bool TriggerRefence = true;
    public bool triggerWall = false;

    private void Ball()
    {
        TriggerRefence = true;
        triggerWall = false;
        for (int i = 0; i < 35; i++)
        {
            if (TriggerRefence)
            {
                Collider2D hit = Physics2D.OverlapCircle(new Vector2(xPosition, yPosition), referenceList[i].transform.localScale.x + 0.0001f, mask);
                
                if (hit == null)
                {
                    TriggerRefence = true;
                }
                else if (hit.CompareTag("wall") )
                {
                    if (!triggerWall )
                    {
                        TriggerRefence = true;
                        angelX *= -1;
                        triggerWall = true;

                    }


                }
                else if (!hit.CompareTag("ball"))
                {
                  
                    TriggerRefence = false;

                }


                
            }

            xPosition += angelX/5;
            yPosition += angelY/5;
            referenceList[i].transform.position = new Vector3(xPosition, yPosition-0.42f, 0);

       

            if (TriggerRefence)
            {
                referenceList[i].SetActive(true);
                ///if(referenceList[i].name.Length)
            }
            else
            {
                 referenceList[i].SetActive(false);
            }
        }
      
    }

    public GameObject randomSelect()
    {
        if(skor>=0 && skor < 50)
        {
            RandomBallNumber = Random.Range(0,3);

        }
        else if (skor >= 50 && skor < 250)
        {
            RandomBallNumber = Random.Range(0, 5);

        }
        else if (skor >= 250 && skor < 1000)
        {
            RandomBallNumber = Random.Range(2,7);

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

        GameObject ball = Instantiate(ballsPrefab[RandomBallNumber],new Vector3(0,-3f ,0), Quaternion.identity) as GameObject;
        return ball;
        

    }
 

}
