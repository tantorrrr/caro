﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitManager : MonoBehaviour
{

    // Use this for initialization
    void Start ()
    {
        Debug.Log("Start " + (SkinManager.Instance as SkinManager).ListSkin.Count);
	}
    
    
}
