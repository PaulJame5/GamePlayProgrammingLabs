using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 12;
    public static bool moveLeft = false;
    public GameObject target;
    private Vector2 initialPos;
   
    
    // Start is called before the first frame update
    void Awake()
    {
        moveLeft = false;
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(moveLeft)
        {
            transform.position = VectorMath.Vector2MoveTowards(transform.position, initialPos, speed * Time.deltaTime);

            transform.localScale = new Vector3(-1, 1, 1);

            if(VectorMath.Vec2Distance(transform.position,initialPos) < 5)
            {
                moveLeft = false;
            }
        }
        else
        {
            transform.position = VectorMath.Vector2MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

            transform.localScale = new Vector3(1, 1, 1);

            if (VectorMath.Vec2Distance(transform.position, target.transform.position) < 5)
            {
                moveLeft = true;
            }
        }
        
    }
}
