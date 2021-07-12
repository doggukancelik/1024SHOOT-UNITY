using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefs : MonoBehaviour
{
    public const string Coins = "Coins";
    public static int coins=100;

    public const string SesAnahtari = "Ses";

    public const string seviyeAnahtari = "Seviye";
    public const string HighAnahtari = "high";

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");

        PlayerPrefs.SetInt("Coins",coins);
        coins = PlayerPrefs.GetInt("Coins");




    }


    #region coin kaydetme
    public static void UpdateCoins()
    {
        //playerPrefs.coins = 100;
        PlayerPrefs.SetInt("Coins", coins);
        coins = PlayerPrefs.GetInt("Coins");
        PlayerPrefs.Save();

    }
    #endregion


    #region ses ayari

    public static void AnaSesAyari(float ses)
    {

        if (ses >= 0f && ses <= 1f)
        {
            PlayerPrefs.SetFloat(SesAnahtari, ses);

        }
    }

    public static float anaSesAl()
    {
        return PlayerPrefs.GetFloat(SesAnahtari);
    }

    #endregion

    public static void highScore(int score)
    {

        if (score>0)
        {
            PlayerPrefs.SetInt(HighAnahtari,score);

        }
    }

    public static int highPrefs()
    {
        return PlayerPrefs.GetInt(HighAnahtari);
    }


    #region seviye Ayari
    public static void SeviyeAyari(int seviye)
    {
        if(seviye>=1 && seviye <= 3)
        {
            PlayerPrefs.SetInt(seviyeAnahtari, seviye);

        }
    }

    public static int seviyeyiAl()
    {
        return PlayerPrefs.GetInt(seviyeAnahtari);
    }
    #endregion
}
