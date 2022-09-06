using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PaintColor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool cover;
    void Start()
    { }

    // Update is called once per frame
    void Update()
    { }

    void OnTriggerEnter(Collider collider)  
    {
        if(collider.gameObject.tag == "Player") {
            Color myColor = GetComponent<Renderer>().material.GetColor("_Color");
            Color targetColor = collider.gameObject.GetComponent<Renderer>().material.GetColor("_Color");
            if(cover) {
                collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", GetComponent<Renderer>().material.GetColor("_Color"));
            }
            else {
                Color newColor = new Color(Math.Min(myColor.r, targetColor.r), Math.Min(myColor.g, targetColor.g), Math.Min(myColor.b, targetColor.b), 1.0f);
                collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", newColor);
            }
        }
    }
}
