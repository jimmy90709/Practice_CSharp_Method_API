using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(1f, 50f)]
    public float Speed = 20;
    public Rigidbody2D Rig;
    public SpriteRenderer Sr;
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Rig.AddForce(Vector2.right * Speed * x);
        if(x >= 0)
        {
            Sr.flipX = false;
        }
        else
        {
            Sr.flipX = true;
        }
    }
    
}
