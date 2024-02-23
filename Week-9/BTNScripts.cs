using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTNScripts : MonoBehaviour
{
    public GameObject Pausepnl;
    public Slider MusicSlider;
    public Slider EffectSlider;
    public AudioSource MusicSource;
    public AudioClip BgSound;



    GameManager gameManager;
    void Start()
    {

        gameManager = GetComponent<GameManager>();

        Pausepnl.SetActive(false);
        MusicSlider.value = 1.0f;
        MusicSlider.onValueChanged.AddListener(MusicLevel);
        MusicSource.clip = BgSound;
        MusicSource.Play();

        EffectSlider.value = 1.0f;
        EffectSlider.onValueChanged.AddListener(EffectLevel);
        
    }

   

    public void EffectLevel(float yeniDeger1)
    {
        gameManager.BirlestirSource.volume = yeniDeger1;
        gameManager.SpawnSource.volume = yeniDeger1;
    }

    public void MusicLevel(float yeniDeger2)
    {
        // Ses seviyesini Slider'ýn deðerine göre ayarla
        MusicSource.volume = yeniDeger2;
    }
    public void PauseBtn()
    { 
    
       Pausepnl.SetActive(true);
    
    }

    public void ContiuneBtn()
    {

        Pausepnl.SetActive(false);

    }
}
