using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public RectTransform mainPanel, storePanel, settingPanel, giftPanel;
    public Button storebutton, giftButton, settingsButton;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;    // sahneArasıGecişProbleminiÇözdü

        //if (SceneManager.GetActiveScene().name == "main")
        //{
        mainPanel.DOAnchorPos(Vector2.zero, 0.8f);


        //}
    }



    public void strorePanelButton()
    {

        mainPanel.DOAnchorPos(new Vector2(0, 2000), 0.25f);
        storePanel.DOAnchorPos(new Vector2(0, 0), 0.25f);
        //mainPanel.GetComponent<RectTransform>().
        
    }

    public void CloseStrorePanelButton()
    {
        mainPanel.DOAnchorPos(new Vector2(0, 0), 0.25f);
        storePanel.DOAnchorPos(new Vector2(0, -2000), 0.25f);

    }

    public void GiftPanelButton()
    {
        mainPanel.DOAnchorPos(new Vector2(0, 2000), 0.25f);
        giftPanel.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);

    }

    public void CloseGiftPanelButton()
    {
        giftPanel.DOAnchorPos(new Vector2(1100, 0), 0.25f);
        mainPanel.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);


    }
    public void SettingsPanelButton()
    {
        mainPanel.DOAnchorPos(new Vector2(0, 2000), 0.25f);
        settingPanel.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);

    }

    public void CloseSettingsPanelButton()
    {
        settingPanel.DOAnchorPos(new Vector2(-1100, 0), 0.25f);
        mainPanel.DOAnchorPos(new Vector2(0, 0), 0.25f).SetDelay(0.25f);


    }

}
