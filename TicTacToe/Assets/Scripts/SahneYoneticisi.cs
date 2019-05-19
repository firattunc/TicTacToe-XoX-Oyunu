using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SahneYoneticisi : MonoBehaviour {

    public void İkiKisilikSahneAc()
    {
        SceneManager.LoadScene("oyunEkrani");

    }
    public void BilgisayarSahneAc()
    {
        SceneManager.LoadScene("Computer");

    }
    public void AnaMenuAc()
    {
        SceneManager.LoadScene("anaMenu");
    }
    public void exit()
    {
        Application.Quit();
    }

}
