using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private Color solidColor;
    void Start()
    {
        solidColor = GetComponent<Renderer>().material.GetColor("_Color");
        GetComponent<Renderer>().material.SetColor("_Color", new Color(solidColor.r, solidColor.g, solidColor.b, 0.5f));
    }

    // Update is called once per frame
    void Update()
    { }

    void OnTriggerEnter(Collider collider)  
    {
        if(collider.gameObject.tag == "Player") {
            Color color = GetComponent<Renderer>().material.GetColor("_Color");
            if(solidColor == collider.gameObject.GetComponent<Renderer>().material.GetColor("_Color")) {
                Debug.Log("Undetected");
            }
            else {
                Debug.Log("Detected");
            }
        }
    }
}
