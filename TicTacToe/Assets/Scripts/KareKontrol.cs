using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KareKontrol : MonoBehaviour {

    public int deger;
    GameObject gamecontrol;
    SpriteRenderer spriteRenderer;
    public Sprite[] sprite;
    BoxCollider bxcollider;
    void Start()
    {
        gamecontrol = GameObject.FindGameObjectWithTag("gameobjecttag");
        spriteRenderer = GetComponent<SpriteRenderer>();
        bxcollider = GetComponent<BoxCollider>();
    }

    
    void OnMouseDown()
    {

        if (gamecontrol.GetComponent<OyunKontrolu>().xOro == true)
        {
            spriteRenderer.sprite = sprite[0];
            gamecontrol.GetComponent<OyunKontrolu>().kareDizi[deger] = 1;
            gamecontrol.GetComponent<OyunKontrolu>().isXClick = true;
        }
        else
        {
            spriteRenderer.sprite = sprite[1];
            gamecontrol.GetComponent<OyunKontrolu>().kareDizi[deger] = 0;
            gamecontrol.GetComponent<OyunKontrolu>().isXClick = false;
        }
            
        gamecontrol.GetComponent<OyunKontrolu>().xOro = !gamecontrol.GetComponent<OyunKontrolu>().xOro;
        gamecontrol.GetComponent<OyunKontrolu>().sayi++;
        bxcollider.enabled = false;



    }

}
