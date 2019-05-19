using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunKontrolu : MonoBehaviour {
    public float xZaman;
    public float yZaman;
    public Text Xzaman;
    public Text Yzaman;
    public bool xOro;
    public int[] kareDizi;
    public int sayi = 0;
    public bool isXClick;
    public bool isWin=false;


    void Update() {       
        isGameFinish();
        if (isXClick)
        {
            countDownO();
            
        }
        else
        {
            countDownX();
        }
        if ((int)xZaman == 0)
        {
            yWin();
        }
        else if ((int)yZaman == 0)
        {
            xWin();
        }
    }

    void isGameFinish()
    {
        
        for (int i = 1; i <= 7; i += 3)
        {
            if (kareDizi[i] == kareDizi[i + 1] && kareDizi[i] == kareDizi[i - 1])
            {
                if (kareDizi[i] == 1)
                {
                    xWin();
                }
                else
                {
                    yWin();

                }
            }
        }
        for (int i = 3; i <= 5; i++)
        {
            if (kareDizi[i] == kareDizi[i - 3] && kareDizi[i] == kareDizi[i + 3])
            {
                if (kareDizi[i] == 1)
                {
                    xWin();
                }
                else
                {
                    yWin();

                }
            }
        }
        if (
            (kareDizi[0] == kareDizi[4] && kareDizi[0] == kareDizi[8]) ||
            (kareDizi[2] == kareDizi[4] && kareDizi[2] == kareDizi[6])
           )
        {
            if (kareDizi[4] == 1)
            {
                xWin();
            }
            else
            {
                yWin();

            }
        }
        Debug.Log(kareDizi);
        if (sayi==9)
        {
            SceneManager.LoadScene("draw");
        }

    }
    public void xWin()
    {
        isWin = true;
        SceneManager.LoadScene("xWin");
    }
    public void yWin()
    {
        isWin = true;
        SceneManager.LoadScene("yWin");
    }
    public void countDownX()
    {
        xZaman -= Time.deltaTime;
        Xzaman.text = "X-Time:" + (int)xZaman;
    }
    public void countDownO()
    {
        yZaman -= Time.deltaTime;
        Yzaman.text = "O-Time:" + (int)yZaman;
    }
    

}
