using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteAudio : MonoBehaviour
{

    bool click = false;
    public Button button;
    public Sprite image1;
    public Sprite image2;
    public musicOynaticisi mzk;


    void Start()
    {

        button = GetComponent<Button>();
        if (AudioListener.pause == false)
        {
            button.GetComponent<Button>().image.sprite = image1;

        }
        else if (AudioListener.pause == true)
        {
            button.GetComponent<Button>().image.sprite = image2;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioListener.pause == false)
        {
            button.GetComponent<Button>().image.sprite = image1;

        }
        else if (AudioListener.pause == true)
        {
            button.GetComponent<Button>().image.sprite = image2;

        }
    }

    public void sessizMod()
    {
        if (click)
        {
            playerPrefs.AnaSesAyari(playerPrefs.anaSesAl());
            AudioListener.pause = false;
            if(AudioListener.pause == false)
            {
                button.GetComponent<Button>().image.sprite = image1;

            }

            click = false;

        }
        else
        {
          
            AudioListener.pause = true;
            if (AudioListener.pause == true)
            {
                button.GetComponent<Button>().image.sprite = image2;

            }


            click = true;
        }
    }
}
