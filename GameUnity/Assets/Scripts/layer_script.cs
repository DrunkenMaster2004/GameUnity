using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layer_script : MonoBehaviour
{
    public Rigidbody2D layer1;
    public float ms = 5f;
    // Start is called before the first frame update
    void Start()
    {
        layer1 = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        Vector3 mI = new Vector3(-Input.GetAxis("Horizontal"), 0, 0);
        layer1.MovePosition(transform.position + mI*Time.deltaTime*ms);
        
    }
}
