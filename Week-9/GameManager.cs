using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class GameManager : MonoBehaviour
{
    public GameObject[] RandomSayi; // Oluþturalacak Karakter;
    public Transform SpawnPoint; // Oluþturulacak sayýnýn spawn noktasý
    public float Sure = 3f;
 
    public Camera mainCamera;
    public Transform leftBorder, rightBorder, topBorder, bottomBorder;
    public float borderDepth;

    public AudioSource BirlestirSource;
    public AudioSource SpawnSource;
    public AudioClip BirlestirClip;

    public AudioClip SpawnClip;

    BTNScripts btnScripts;

    void Start()
    {
        InvokeRepeating("SpawnSayi", 0f, Sure);
        btnScripts=gameObject.GetComponent<BTNScripts>();
        BirlestirSource = gameObject.AddComponent<AudioSource>();
        SpawnSource = gameObject.AddComponent<AudioSource>();
        BirlestirSource.clip = BirlestirClip;
        SpawnSource.clip = SpawnClip;

    }

    private void Awake()
    {
        float camY = mainCamera.transform.position.y;
        float camX = mainCamera.transform.position.x;

        topBorder.position = new Vector3(0f, topBorder.position.y, borderDepth);
        bottomBorder.position = new Vector3(0f, bottomBorder.position.y, borderDepth);
        float halfScreenHeight = mainCamera.orthographicSize;
        topBorder.position = new Vector3(topBorder.position.x + camX, halfScreenHeight + camY, borderDepth);
        bottomBorder.position = new Vector3(bottomBorder.position.x + camX, -halfScreenHeight + camY, borderDepth);

        leftBorder.position = new Vector3(leftBorder.position.x, 0f, borderDepth);
        rightBorder.position = new Vector3(rightBorder.position.x, 0f, borderDepth);
        float halfScreenWidth = mainCamera.aspect * mainCamera.orthographicSize;
        leftBorder.position = new Vector3(-halfScreenWidth + camX, 0f + camY, borderDepth);
        rightBorder.position = new Vector3(halfScreenWidth + camX, 0f + camY, borderDepth);

        float borderWidth = halfScreenWidth * 2f;
        topBorder.localScale = new Vector3(borderWidth, topBorder.localScale.y, topBorder.localScale.z);
        bottomBorder.localScale = new Vector3(borderWidth, bottomBorder.localScale.y, bottomBorder.localScale.z);

        float borderHeight = halfScreenHeight * 2f;
        leftBorder.localScale = new Vector3(leftBorder.localScale.x, borderHeight, leftBorder.localScale.z);
        rightBorder.localScale = new Vector3(rightBorder.localScale.x, borderHeight, rightBorder.localScale.z);

    }
  

    void SpawnSayi()

    {
        if (btnScripts.Pausepnl.active==false)
        {
            GameObject RandomSayiSec = RandomSayi[Random.Range(0, RandomSayi.Length)];
            Instantiate(RandomSayiSec, SpawnPoint.position, SpawnPoint.rotation);
            PlaySpawnSound();
        }
        

    }

    public void  PlayCollisionSound()
    {
        // AudioSource etkin deðilse, etkinleþtir
        if (!BirlestirSource.enabled)
        {
            BirlestirSource.enabled = true;
        }

        // Ses dosyasýný çal
        BirlestirSource.Play();
    }

    public void PlaySpawnSound()
    {
        if (!SpawnSource.enabled)
        {
            SpawnSource.enabled = true;
        }

        // Ses dosyasýný çal
        SpawnSource.Play();
    }

}
