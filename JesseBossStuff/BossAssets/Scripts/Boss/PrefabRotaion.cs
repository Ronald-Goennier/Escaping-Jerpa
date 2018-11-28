﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabRotaion : MonoBehaviour {

    public Transform target;
    private Vector3 v_diff;
    private float atan2;
	
	// Update is called once per frame
	void Update () 
    {
        Rotation();
    }

    void Rotation()
    {
        v_diff = (target.position - transform.position);
        atan2 = Mathf.Atan2(v_diff.x, v_diff.y);
        transform.rotation = Quaternion.Euler(0f, 0f, -atan2 * Mathf.Rad2Deg);
    }
}
