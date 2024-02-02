using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAndWalk : MonoBehaviour
{
    private Animator OyuncuAnimasyon;
  
    // Start is called before the first frame update
    void Start()
    {
        OyuncuAnimasyon = GetComponent<Animator>();
      
    }

    private void FixedUpdate()
    {
      
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            OyuncuAnimasyon.SetBool("isWalking", true);
            transform.Translate(new Vector3(0, 0, 2f) * Time.deltaTime);

        }
        else
        {
            OyuncuAnimasyon.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            OyuncuAnimasyon.SetBool("isRunning", true);
            transform.Translate(new Vector3(0, 0, 4f) * Time.deltaTime);

        }
        else
        {
            OyuncuAnimasyon.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.Alpha1))
        {
            OyuncuAnimasyon.SetBool("iskey1", true);

        }
        else
        {
            OyuncuAnimasyon.SetBool("iskey1", false);
        }


        if (Input.GetKey(KeyCode.Alpha2))
        {
            OyuncuAnimasyon.SetBool("iskey2", true);


        }
        else
        {
            OyuncuAnimasyon.SetBool("iskey2", false);
        }


        if (Input.GetKey(KeyCode.Alpha3))
        {
            OyuncuAnimasyon.SetBool("iskey3", true);


        }
        else
        {
            OyuncuAnimasyon.SetBool("iskey3", false);
        }
    }
}
