using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5;
    Vector2 mousePosition;
    Rigidbody2D rb;
    float bleed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {  


        if(Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log("Mouse Position: " + mousePosition);

            //
            Vector2 direction = ((Vector2)mousePosition - (Vector2) transform.position);
            Vector2 moveDir = Vector3.Normalize(direction);
           speed = Random.Range(1, 20);
            rb.velocity = moveDir * speed;
        }
    }
}
