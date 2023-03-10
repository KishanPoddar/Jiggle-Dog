using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -rotateSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            GameManager.instance.IncreaseScore();
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            GameManager.instance.GameOver();
        }
    }
}
