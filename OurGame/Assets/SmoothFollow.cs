using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//平滑跟隨目標

public class SmoothFollow : MonoBehaviour
{

    public Transform FollowTarget;      //跟隨目標
    public float Radius;                //跟隨距離
    public float Smooth;                //平滑速度
    public float ySmooth;


    private Vector3 smoothPosition = Vector3.zero;
    
    void Start()
    {
        if (!FollowTarget)
        {
            this.enabled = false;
        }
        else
        {
            transform.parent = null;
        }

    }

    
    void Update()
    {
        if (CheckMargin())
        {
            smoothPosition.y = Mathf.Lerp(transform.position.y, FollowTarget.position.y, ySmooth * Time.deltaTime);
            smoothPosition.x = Mathf.Lerp(transform.position.x, FollowTarget.position.x, Smooth * Time.deltaTime);
            smoothPosition.z = Mathf.Lerp(transform.position.z, FollowTarget.position.z, Smooth * Time.deltaTime);
            transform.position = smoothPosition;
        }
    }

    bool CheckMargin()
    {
        //檢測此物件與追隨目標的距離是否大於跟隨距離
        return Vector3.Distance(transform.position, FollowTarget.position) > Radius;
    }


}
