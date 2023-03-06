using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;
using GoogleMobileAds;

public class Game : MonoBehaviour
{
    public string answer;
    public static string userAnswer;

    public GameObject completeLevelUI;
    public GameObject hintUI;
    public GameObject answerUI;


    private InterstitialAd interstitial;

    public Button TipsButtons;
    public Button TipsAnswer;
    public Text answerTips;


    //Change tip image
    public Image oldImage;
    public Sprite newImage;

    private RewardedAd rewardedAd;
    private RewardedAd rewardedAdAnswer;
    private bool ReklamGo1 = false;
    private bool ReklamGo2 = false;


    public AudioSource correct;

    private int lastCharacterForAd;

    // Start is called before the first frame update
    void Start()
    {

        Scene scene = SceneManager.GetActiveScene();
        char lastCharacter = scene.name[scene.name.Length - 1];
        lastCharacterForAd = lastCharacter - '0';

       

        TipsButtons.enabled = false;

        userAnswer = "";
        answerTips.text = "Answer: "+answer;

        hintUI.SetActive(false);
        answerUI.SetActive(false);
        completeLevelUI.SetActive(false);

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        this.RequestInterstitial();

        //*****************************************************************************************************************
        string adUnitId;
#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3778488598855493/5137967683";
#elif UNITY_IPHONE
            adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;

        this.rewardedAdAnswer = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAdAnswer.OnAdLoaded += HandleRewardedAdLoaded;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
        this.rewardedAdAnswer.LoadAd(request);

        //*****************************************************************************************************************

    }

    //*****************************************************************************************************************

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        oldImage.sprite = newImage;
        TipsButtons.enabled = true;
        //MonoBehaviour.print("HandleRewardedAdLoaded event received");
    }


    private void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            rewardedAd.Show();
            ReklamGo1 = true;
            StartCoroutine(Text());
            
        }
    }
    private void UserChoseToWatchAd2()
    {
        if (this.rewardedAdAnswer.IsLoaded())
        {
            this.rewardedAdAnswer.Show();
            ReklamGo2 = true;
            StartCoroutine(Text2());
            
        }
    }

    IEnumerator Text() 
    {
        yield return new WaitForSeconds(0.5f);
        hintUI.SetActive(true);
    }
    IEnumerator Text2()
    {
        yield return new WaitForSeconds(0.5f);
        answerUI.SetActive(true);
    }

    //*****************************************************************************************************************
    private void RequestInterstitial()
    {

#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3778488598855493/4319953882";
#elif UNITY_IPHONE
                string adUnitId = "ca-app-pub-3778488598855493/5133967402";
#else
                string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }
    //***************************************************************************************Tuþlar
    public void Enter()
    {
        if (userAnswer.CompareTo(answer) == 0  )
        {
            correct.Play();
            if (interstitial.IsLoaded())
            {
                
                if (lastCharacterForAd % 2 == 0)
                {
                    //***************************************************************
                    interstitial.Show();
                }
            }
            completeLevelUI.SetActive(true);
        }
        else
        {
            StartCoroutine(Wrong());
        }
    }

    public void hint()
    {
        if(ReklamGo1 == true) {
            hintUI.SetActive(true);
        }
        else
        {
            UserChoseToWatchAd();
        }
    }
    public void closeHint()
    {
        hintUI.SetActive(false);

    }
    public void closeAnswer()
    {
        hintUI.SetActive(false);
        answerUI.SetActive(false);
    }
    public void answerHint()
    {
        if (ReklamGo2 == true)
        {
            answerUI.SetActive(true);
        }
        else
        {
            UserChoseToWatchAd2();
        }

    }



    public IEnumerator Wrong()
    {
        userAnswer = "Wrong";
        yield return new WaitForSeconds(0.5f);
        userAnswer = "";
    }
    
    public void Delete()
    {
        if(userAnswer.Length != 0)
        {
            userAnswer = userAnswer.Substring(0, userAnswer.Length - 1);
        }
    }
    public void One()
    {
        userAnswer += "1";
    }
    public void Two()
    {
        userAnswer += "2";
    }
    public void Three()
    {
        userAnswer += "3";
    }
    public void Four()
    {
        userAnswer += "4";
     }
    public void Five()
    {
        userAnswer += "5";
    }
    public void Six()
    {
        userAnswer += "6";
    }
    public void Seven()
    {
        userAnswer += "7";
    }
    public void Eight()
    {
        userAnswer += "8";
    }
    public void Nine()
    {
        userAnswer += "9";
    }
    public void Zero()
    {
        userAnswer += "0";
    }
    public void GoMenu()
    {
        hintUI.SetActive(false);
        answerUI.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
