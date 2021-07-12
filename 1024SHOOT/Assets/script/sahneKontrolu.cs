using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class sahneKontrolu : MonoBehaviour
{
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CallSceneWithNumber(int SceneNumber)
    {
        //DOTween.Clear(true);
        SceneManager.LoadScene(SceneNumber);
    }

    public void CallSceneWithName(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void retryScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }


    public void backScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    public void again()
    {
        StartCoroutine(againx());
    }

    IEnumerator againx()
    {

        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }





}
