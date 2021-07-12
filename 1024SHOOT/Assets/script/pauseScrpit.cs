using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class pauseScrpit : MonoBehaviour
{

    bool isPaused = false;
    public Sprite image;
    public Sprite image2;
    public Button button;
    public AudioClip ses;
    public GameObject pausePanel;
    public float time;
    public GameObject panelAll;

    public GameObject shopPanel;
    public GameObject elliPanel;
    public GameObject otuzPanel;
    public GameObject yirmiPanel;

    public GameObject touchPanel;

    public void Start()
    {
        button = GetComponent<Button>();
        button.GetComponent<Button>().image.sprite = image;
    }
    private void Update()
    {
        if (Time.timeScale == 1)
        {
            button.GetComponent<Button>().image.sprite = image;

        }
        if(Time.timeScale == 0)
        {
            button.GetComponent<Button>().image.sprite = image2;
            touchPanel.SetActive(false);
        }
    }

    public void pauseGame()
    {
        if (isPaused)
        {
            panelAll.SetActive(false);
            pausePanel.SetActive(false);
            button.GetComponent<Button>().image.sprite = image;
            Time.timeScale = 1f;
            isPaused = false;

        }
        else
        {
            AudioSource.PlayClipAtPoint(ses, transform.position);

            button.GetComponent<Button>().image.sprite = image2;
            panelAll.SetActive(true);
            pausePanel.SetActive(true);
            shopPanel.SetActive(false);
            yirmiPanel.SetActive(false);
            elliPanel.SetActive(false);
            otuzPanel.SetActive(false);
            Time.timeScale = 0f;
            isPaused = true;
        }
    }

}
