using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float mSpeed = 1;
    public float rSpeed = 1;



    void Start()
    {
        
    }

    
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Verrical");


        transform.Translate(0, 0, mSpeed * -v);
        transform.Rotate(0, rSpeed *h, 0);
    }
}
