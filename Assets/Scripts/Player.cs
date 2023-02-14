using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;
    public float moveSpeed;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    } 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x< Screen.width / 2)
            {
                sp.flipX = true;
                rb.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                sp.flipX = false;
                rb.velocity = Vector2.right * moveSpeed;
            }
        }
         

    }
}
