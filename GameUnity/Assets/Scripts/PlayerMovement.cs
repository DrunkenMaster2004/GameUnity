using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public float jf=5f;
    void Start()
    {
       player=GetComponent<Rigidbody2D>();
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            player.AddForce(Vector3.up*jf,ForceMode2D.Impulse);
        }
    }
}
