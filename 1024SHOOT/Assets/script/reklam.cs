using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using Random = UnityEngine.Random;

public class reklam : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardedAd rewardedAd;



    public GameObject bombCoin;
    public GameObject yatayCoin;
    public GameObject dikeyCoin;
    public GameObject gift;
    public money para;
    // Start is called before the first frame update
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();

        CreateAndLoadRewardedAd();
        RequestInterstitial();
    }

    #region bannerAds
    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "my id";
#elif UNITY_IPHONE
            string adUnitId = "my id";
#else
            string adUnitId = "my id";
#endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }


    #endregion


    #region requestINSTERTİAL

    public void  RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "my id";
#elif UNITY_IPHONE
        string adUnitId = "my id";
#else
        string adUnitId = "my id";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        interstitial.OnAdClosed += interstitial_OnAdClosed;
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
        //this.interstitial.OnAdLoaded += Interstitial_Onloaded;
    }

    private void interstitial_OnAdClosed(object sender, EventArgs e)
    {
        this.RequestInterstitial();
    }

    //private void Interstitial_Onloaded(object sender, EventArgs e)
    //{
    //    interstitial.Show();
    //}
 
    public void ShowIntersitial()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

        }
    }




    #endregion

    #region rewardedAds

    public RewardedAd CreateAndLoadRewardedAd()//x
    {
#if UNITY_ANDROID
        string adUnitId = "my id";
#elif UNITY_IPHONE
            string adUnitId = "my id";
#else
            string adUnitId = "my id";
#endif


        this.rewardedAd = new RewardedAd(adUnitId);

        //this.rewardedAd.OnAdLoaded += RewardedAd_OnLoaded;        //x
        this.rewardedAd.OnUserEarnedReward += RewardedAd_OnUserEarnedReward;
        this.rewardedAd.OnAdClosed += RewardedAd_OnAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);

        return rewardedAd;         

    }

    private void RewardedAd_OnAdClosed(object sender, EventArgs e)
    {
        ParayiArttir(0);
        this.CreateAndLoadRewardedAd();
    }

    private void RewardedAd_OnUserEarnedReward(object sender, Reward e)
    {
        if(bombCoin!=null || yatayCoin!=null || dikeyCoin != null)
        {
            if (bombCoin.activeSelf == true)
            {
                ParayiArttir(50);
            }
            if (yatayCoin.activeSelf == true)
            {
                ParayiArttir(30);
            }
            if (dikeyCoin.activeSelf == true)
            {
                ParayiArttir(20);
            }
        }
        else
        {
            if (gift.activeSelf == true)
            {
                ParayiArttir(15);
            }
        }
       

    }

    //public void RewardedAd_OnLoaded(object sender, EventArgs e)
    //{
    //    rewardedAd.Show();
    //}


    public void showRewarded()
    {
        if (rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();

        }
        //CreateAndLoadRewardedAd().Show();
    }

    #endregion

    public void ParayiArttir(int paraMiktari)
    {
        para.paraArrtir(paraMiktari);
    }
}
