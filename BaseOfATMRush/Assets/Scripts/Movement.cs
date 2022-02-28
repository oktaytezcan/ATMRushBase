using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float horSpeed;
    float hor;
    void Start()
    {
        
    }

    
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(hor * horSpeed * Time.deltaTime, 0f, movementSpeed * Time.deltaTime);

       




    }
}
