using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //void OnMove(InputValue movementValue) 
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(45, 45, 45);
        transform.Rotate(45 * Time.deltaTime, 45 * Time.deltaTime, 45 * Time.deltaTime);
        transform.Translate(1 * Time.deltaTime, 0, 0);
    }
}
