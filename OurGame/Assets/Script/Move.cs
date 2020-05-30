using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float mSpeed = 0.5f;
    public float rSpeed = 0.5f;



    void Start()
    {
        
    }

    
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");


        transform.Translate(0, 0, (mSpeed *  v));
        transform.Rotate(0, rSpeed * h, 0);
    }
}
