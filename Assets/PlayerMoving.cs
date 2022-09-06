using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rigid;
    private Transform transform;
    Vector3 startPos;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        transform = gameObject.GetComponent<Transform>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 finalmove = transform.position;
        finalmove.z += 5 * Time.deltaTime;
        if (Input.GetKey (KeyCode.A))
            finalmove.x -= 1;
        if (Input.GetKey (KeyCode.D))
            finalmove.x += 1;

        if(finalmove.x > 14)
            finalmove.x = 14;
        else if(finalmove.x < 12)
            finalmove.x = 12;

        transform.position = finalmove;
        
    }
}
