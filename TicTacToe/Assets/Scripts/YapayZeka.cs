using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YapayZeka : MonoBehaviour {

    public GameObject[] kareler;
    public Sprite[] sprite;
    GameObject oyunkontrol;
    OyunKontrolu kontrol;
    BoxCollider bxcollider;
    SpriteRenderer spriterenderer;
    int i = 0;
   

	void Start () {

        oyunkontrol = GameObject.FindGameObjectWithTag("gameobjecttag");
        kontrol = oyunkontrol.GetComponent<OyunKontrolu>();
    }

	void Update () {
        if (kontrol.isWin==false)
        {
            comTurn();
        }
        
	}
    public void comTurn()
    {
        if (kontrol.xOro == false)
        {
            
            //right
            if (
                    (kontrol.kareDizi[i] == kontrol.kareDizi[i + 1]) &&
                    kontrol.kareDizi[i + 2] == 4
                    )
                {
                    bxcollider = kareler[i + 2].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 2].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 2] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                kontrol.countDownO();

            }
                else if (
                    (kontrol.kareDizi[i+3] == kontrol.kareDizi[i + 4]) &&
                    kontrol.kareDizi[i + 5] == 7
                    )
                {
                    bxcollider = kareler[i + 5].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 5].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 5] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i+6] == kontrol.kareDizi[i + 7]) &&
                    kontrol.kareDizi[i + 8] == 10
                    )
                {
                    bxcollider = kareler[i + 8].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 8].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 8] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //left
                else if (
                    (kontrol.kareDizi[i + 1] == kontrol.kareDizi[i + 2]) &&
                    kontrol.kareDizi[i] == 2
                    )
                {
                    bxcollider = kareler[i].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i + 4] == kontrol.kareDizi[i + 5]) &&
                    kontrol.kareDizi[i+3] == 5
                    )
                {
                    bxcollider = kareler[i+3].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i+3].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i+3] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i + 7] == kontrol.kareDizi[i + 8]) &&
                    kontrol.kareDizi[i+6] == 8
                    )
                {
                    bxcollider = kareler[i+6].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i+6].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i+6] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //mid
                else if (
                    (kontrol.kareDizi[i] == kontrol.kareDizi[i + 2]) &&
                    kontrol.kareDizi[i + 1] == 3
                    )
                {
                    bxcollider = kareler[i + 1].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 1].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i+1] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i+3] == kontrol.kareDizi[i + 5]) &&
                    kontrol.kareDizi[i + 4] == 6
                    )
                {
                    bxcollider = kareler[i + 4].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 4].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i+4] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i+6] == kontrol.kareDizi[i + 8]) &&
                    kontrol.kareDizi[i + 7] == 9
                    )
                {
                    bxcollider = kareler[i + 7].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 7].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i+7] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //bottomvertical
                else if (
                    (kontrol.kareDizi[i] == kontrol.kareDizi[i + 3]) &&
                    kontrol.kareDizi[i + 6] == 8
                    )
                {
                    bxcollider = kareler[i + 6].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 6].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i+6] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i+1] == kontrol.kareDizi[i + 4]) &&
                    kontrol.kareDizi[i + 7] == 9
                    )
                {
                    bxcollider = kareler[i + 7].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 7].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 7] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                        (kontrol.kareDizi[i+2] == kontrol.kareDizi[i + 5]) &&
                        kontrol.kareDizi[i + 8] == 10
                        )
                {
                    bxcollider = kareler[i + 8].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 8].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 8] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //middle vertical
                else if (
                    (kontrol.kareDizi[i] == kontrol.kareDizi[i + 6]) &&
                    kontrol.kareDizi[i + 3] == 5
                    )
                {
                    bxcollider = kareler[i + 3].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 3].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 3] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i + 1] == kontrol.kareDizi[i + 7]) &&
                    kontrol.kareDizi[i + 4] == 6
                    )
                {
                    bxcollider = kareler[i + 4].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 4].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 4] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                        (kontrol.kareDizi[i + 2] == kontrol.kareDizi[i + 8]) &&
                        kontrol.kareDizi[i + 5] == 7
                        )
                {
                    bxcollider = kareler[i + 5].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 5].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 5] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //topvertical
                else if (
                    (kontrol.kareDizi[i+3] == kontrol.kareDizi[i + 6]) &&
                    kontrol.kareDizi[i] == 2
                    )
                {
                    bxcollider = kareler[i].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i + 4] == kontrol.kareDizi[i + 7]) &&
                    kontrol.kareDizi[i + 1] == 3
                    )
                {
                    bxcollider = kareler[i + 1].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 1].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 1] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                        (kontrol.kareDizi[i + 5] == kontrol.kareDizi[i + 8]) &&
                        kontrol.kareDizi[i + 2] == 4
                        )
                {
                    bxcollider = kareler[i + 2].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 2].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 2] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //crossmid
                else if (
                    (kontrol.kareDizi[i ] == kontrol.kareDizi[i + 8]) &&
                    kontrol.kareDizi[i + 4] == 6
                    )
                {
                    bxcollider = kareler[i + 4].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 4].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 4] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                        (kontrol.kareDizi[i + 2] == kontrol.kareDizi[i + 6]) &&
                        kontrol.kareDizi[i + 4] == 6
                        )
                {
                    bxcollider = kareler[i + 4].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 4].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 4] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                //crosscorner
                else if (
                    (kontrol.kareDizi[i ] == kontrol.kareDizi[i +4]) &&
                    kontrol.kareDizi[i + 8] == 10
                    )
                {
                    bxcollider = kareler[i + 8].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 8].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 8] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                        (kontrol.kareDizi[i + 2] == kontrol.kareDizi[i + 4]) &&
                        kontrol.kareDizi[i + 6] == 8
                        )
                {
                    bxcollider = kareler[i + 6].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 6].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 6] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                    (kontrol.kareDizi[i + 4] == kontrol.kareDizi[i + 8]) &&
                    kontrol.kareDizi[i ] == 2
                    )
                {
                    bxcollider = kareler[i ].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i ] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else if (
                        (kontrol.kareDizi[i + 4] == kontrol.kareDizi[i + 6]) &&
                        kontrol.kareDizi[i + 2] == 4
                        )
                {
                    bxcollider = kareler[i + 2].GetComponent<BoxCollider>();
                    spriterenderer = kareler[i + 2].GetComponent<SpriteRenderer>();
                    spriterenderer.sprite = sprite[1];
                    bxcollider.enabled = false;
                    kontrol.kareDizi[i + 2] = 0;
                    kontrol.xOro = !kontrol.xOro;
                    kontrol.sayi++;
                }
                else
                {
                    for (int i = 0; i < 9; i++)
                    {
                        int x = Random.Range(0, 9);
                        if (kontrol.kareDizi[x] == 0 || kontrol.kareDizi[x] == 1)
                        {
                            continue;
                        }
                        
                        
                        else
                        {
                            bxcollider = kareler[x].GetComponent<BoxCollider>();
                            spriterenderer = kareler[x].GetComponent<SpriteRenderer>();
                            spriterenderer.sprite = sprite[1];
                            bxcollider.enabled = false;
                            kontrol.kareDizi[x] = 0;
                            kontrol.xOro = !kontrol.xOro;
                            kontrol.sayi++;
                            break;
                        }
                    }
                    
                    
                }








        }
    }

}
