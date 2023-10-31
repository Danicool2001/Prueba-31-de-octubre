using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QualityChange : MonoBehaviour
{ 
    int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeQuality();
    }

    public void ChangeQuality()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            QualitySettings.SetQualityLevel(index = 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            QualitySettings.SetQualityLevel(index = 1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            QualitySettings.SetQualityLevel(index = 2);
        }
    }
}
