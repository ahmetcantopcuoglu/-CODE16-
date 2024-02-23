using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNumber : MonoBehaviour
{

    private bool Tiklandimi = false;
    private Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KarakterSecildi();
    }

    void KarakterSecildi()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //fare týklamasý baþlar
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                //Karaktere týklandý taþýma baþlar
                Tiklandimi = true;
                offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);

            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            Tiklandimi = false;
        }

        if (Tiklandimi)
        {
            //karakter poz. fare poz. güncellenir
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePosition.x + offset.x, mousePosition.y + offset.y, transform.position.z);
        }

       
    }

}
