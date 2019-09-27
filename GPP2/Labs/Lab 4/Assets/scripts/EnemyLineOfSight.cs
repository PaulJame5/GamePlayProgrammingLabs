using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineOfSight : MonoBehaviour
{
    public Transform player;

    bool playSound = false;

    public AudioClip clip;
    public AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
        playSound = false;
    }

    // Update is called once per frame
    void Update()
    {
        //var rayCast = Physics2D.Raycast(transform.position, Vector2.right * 60, Mathf.Infinity);


        // Make sure where within range so sound doesn't keep playing 
        if (VectorMath.Vec2Distance(transform.position, player.transform.position) < 10)
        {
            // if moving right
            if (EnemyMove.moveLeft == false)
            {
                if (player.transform.position.x > transform.position.x)
                {
                    if (VectorMath.Vector2Angle(transform.position, player.position) > -60 && VectorMath.Vector2Angle(transform.position, player.position) < 60)
                    {
                        player.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                        playSound = true;
                    }
                    else
                    {
                        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                    }
                }
                else
                {
                    player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                }
            } // end moving right
            else if (EnemyMove.moveLeft == true)
            {
                if (player.transform.position.x < transform.position.x)
                {
                    if ((VectorMath.Vector2Angle(transform.position, player.position) < -120 &&
                        VectorMath.Vector2Angle(transform.position, player.position) > -180)
                        ||
                        (VectorMath.Vector2Angle(transform.position, player.position) > 120 &&
                        VectorMath.Vector2Angle(transform.position, player.position) < 180))
                    {
                        player.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
                    }
                    else
                    {
                        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                        playSound = true;
                    }
                }
                else
                {
                    player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
                }
            }
            PlaySound();
        } // end distance check
    }



    void PlaySound()
    {
        if(!playSound)
        {
            aud.PlayOneShot(clip);
            playSound = true;
        }
        else if(aud.isPlaying == false)
        {
            playSound = false;
        }
    }
}

