using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject pausePanel;

    public GameObject bombCoin;
    public GameObject yatayCoin;
    public GameObject dikeyCoin;

    public GameObject nextVersionPanel;
    public GameObject panelAll;
    public GameObject touchPanel;


    public void shopPanelx()
    {
        panelAll.SetActive(true);
        shopPanel.SetActive(true);
        touchPanel.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 0f;
    }

    public void panelCikis()
    {
        pausePanel.SetActive(false);
        panelAll.SetActive(false);

        shopPanel.SetActive(false);
        Time.timeScale = 1f;

        //StartCoroutine(WaiT());

    }

    //IEnumerator WaiT()
    //{
    //    yield return new WaitForSecondsRealtime(1.5f);
    //    //GameObject.FindObjectOfType<ballDirection>().enabled = false;
    //    Time.timeScale = 1f;
    //}

    public void EllireklamPanelAc()
    {
        panelAll.SetActive(true);
        bombCoin.SetActive(true);
        shopPanel.SetActive(false);
        Time.timeScale = 0f;
    }
    public void otuzreklamPanelAc()
    {
        panelAll.SetActive(true);

        yatayCoin.SetActive(true);
        shopPanel.SetActive(false);
        Time.timeScale = 0f;
    }
    public void yirmireklamPanelAc()
    {
        panelAll.SetActive(true);

        dikeyCoin.SetActive(true);
        shopPanel.SetActive(false);
        Time.timeScale = 0f;
    }


    public void SEllireklamPanelAc()
    {
        bombCoin.SetActive(true);
    }
    public void SotuzreklamPanelAc()
    {
        yatayCoin.SetActive(true);
    }
    public void SyirmireklamPanelAc()
    {

        dikeyCoin.SetActive(true);
    }
    public void reklamPanelKapa()
    {
        panelAll.SetActive(false);

        bombCoin.SetActive(false);
        yatayCoin.SetActive(false);
        dikeyCoin.SetActive(false);
        shopPanel.SetActive(true);      //yeniiii
        Time.timeScale = 1f;

        //StartCoroutine(WaiT());

    }





    public void reklamPanelKapaStore()
    {
        //panelAll.SetActive(false);

        bombCoin.SetActive(false);
        yatayCoin.SetActive(false);
        dikeyCoin.SetActive(false);

    }



    public void nextVersion()
    {
        nextVersionPanel.SetActive(true);
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(1.2f);
        nextVersionPanel.SetActive(false);
    }


}
