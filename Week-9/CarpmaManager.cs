using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarpmaManager : MonoBehaviour
{

    public GameObject Prefab2, Prefab4, Prefab8, Prefab16, Prefab32, Prefab64, Prefab128, Prefab256, Prefab512, Prefab1024;
    private bool hasCollide = true;

    GameManager gameManager;

    
    public void Awake()
       
    {
        gameManager =Object.FindAnyObjectByType<GameManager>();
    }

    private void Start()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("2") && collision.otherCollider.gameObject.tag == "2")
        {
            hasCollide = false;
            Debug.Log("2 ve 2 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab4, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("4") && collision.otherCollider.gameObject.tag == "4")
        {
            hasCollide = false;
            Debug.Log("4 ve 4 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab8, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("8") && collision.otherCollider.gameObject.tag == "8")
        {
            hasCollide = false;
            Debug.Log("8 ve 8 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab16, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("16") && collision.otherCollider.gameObject.tag == "16")
        {
            hasCollide = false;
            Debug.Log("16 ve 16 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab32, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound(); 
            }
        }
        else if (collision.gameObject.CompareTag("32") && collision.otherCollider.gameObject.tag == "32")
        {
            hasCollide = false;
            Debug.Log("32 ve 32 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab64, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("64") && collision.otherCollider.gameObject.tag == "64")
        {
            hasCollide = false;
            Debug.Log("64 ve 64 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab128, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("128") && collision.otherCollider.gameObject.tag == "128")
        {
            hasCollide = false;
            Debug.Log("128 ve 128 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab256, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("256") && collision.otherCollider.gameObject.tag == "256")
        {
            hasCollide = false;
            Debug.Log("256 ve 256 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab512, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("512") && collision.otherCollider.gameObject.tag == "512")
        {
            hasCollide = false;
            Debug.Log("512 ve 512 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab1024, collision.GetContact(0).point, Quaternion.identity);
                gameManager.PlayCollisionSound();
            }
        }
        else if (collision.gameObject.CompareTag("1024") && collision.otherCollider.gameObject.tag == "1024")
        {
            hasCollide = false;
            Debug.Log("1024 ve 1024 Numara Çarptý");
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (!hasCollide)
            {
                Instantiate(Prefab2, collision.GetContact(0).point, Quaternion.identity);
               gameManager.PlayCollisionSound();
            }
        }
           
        
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        hasCollide = true;
       
    }

   

}


