using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
    
    private Text paraText;
    private void Start()
    {
        paraText = GetComponent<Text>();
        paraText.text = PlayerPrefs.GetInt("Coins").ToString();
    }

    private void Update()
    {
        paraText.text = PlayerPrefs.GetInt("Coins").ToString();

    }


    public void paraAzalt(int paraMiktari)
    {

        int coins = PlayerPrefs.GetInt("Coins");      ///loook     yukarıyaaaaaaaa   18/12/2020
        coins -= paraMiktari;
        PlayerPrefs.SetInt("Coins", coins);
        paraText.text = PlayerPrefs.GetInt("Coins").ToString();

    }
    public void paraArrtir(int paraMiktari)
    {
        int coins = PlayerPrefs.GetInt("Coins");      ///loook     yukarıyaaaaaaaa   18/12/2020
        coins += paraMiktari;
        PlayerPrefs.SetInt("Coins",coins);
        paraText.text = PlayerPrefs.GetInt("Coins").ToString();

    }

}
