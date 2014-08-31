using UnityEngine;
using System.Collections;
using System;

public class BaseBrick : MonoBehaviour {

   
    public Vector3 BottomL
    {
        get
        {
            return new Vector3(transform.localPosition.x - transform.localScale.x/2, 
                               transform.localPosition.y - transform.localScale.y/2, 
                               transform.localPosition.z);
        }

        set
        {
            value = this.BottomL;
        }
    }

    public Vector3 BottomR
    {
        get
        {
            return new Vector3(transform.localPosition.x + transform.localScale.x/2, 
                               transform.localPosition.y - transform.localScale.y/2, 
                               transform.localPosition.z);
        }
    }

    public Vector3 TopR
    {
        get
        {
            return new Vector3(transform.localPosition.x + transform.localScale.x/2, 
                               transform.localPosition.y + transform.localScale.y/2, 
                               transform.localPosition.z);
        }
    }

    public Vector3 TopL
    {
        get
        {
            return new Vector3(transform.localPosition.x - transform.localScale.x/2, 
                               transform.localPosition.y + transform.localScale.y/2, 
                               transform.localPosition.z);
        }
    }









}

