﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTeddyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //triple width
        Vector3 newScale = transform.localScale;
        newScale.x *= 3;
        transform.localScale = newScale;
    }

}
