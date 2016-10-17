﻿using UnityEngine;
using System.Collections;

public class ray : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                string target = hit.collider.name;
                if (target == "Cube")
                {
                    hit.transform.localScale = new Vector3((float) 0.5, (float) 0.5, (float)0.5);
                }
            }
        }
	
	}
}
