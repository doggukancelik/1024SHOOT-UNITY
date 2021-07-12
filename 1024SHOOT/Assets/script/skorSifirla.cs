using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class skorSifirla : MonoBehaviour
{
    public Text skorx;
    bool xko = false;

    // Start is called before the first frame update

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        collisonForBalls.skor = 0;

    }

    void Start()
    {
        if (!xko)
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
            xko = true;
        }
        //collisonForBalls.skor = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
