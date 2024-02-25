using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DragonControl : MonoBehaviour
{
    [SerializeField] private float speed;

    private FixedJoystick fixedJoystick;
    private Rigidbody rigidbody;

    private void OnEnable()
    {
        fixedJoystick = FindAnyObjectByType<FixedJoystick>();
        rigidbody = gameObject.GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal,0,yVal);
        rigidbody.velocity = movement * speed;

        if(xVal != 0 && yVal != 0) 
                   transform.eulerAngles = new Vector3(transform.eulerAngles.x,Mathf.Atan2(xVal,yVal)*Mathf.Rad2Deg,transform.eulerAngles.z);
        
    }

}
