using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class animate : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rigidbody;
    public SpriteRenderer SR;
    public int PlayerScore = 0;
    void Start()
    {
        //vars
        int SpritePosition = 5;
        int PlayerHealth = 10;
        int EnemyCount = 1;

        //TargetColor = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //&& SR.color = Color.red;
        {
            // Vector2(transform.position, x+5)
          //  SR.color = LightBlue;

        } else
        {
            SR.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody.velocity = new Vector2(5, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody.velocity = new Vector2(-5, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }
        public void Jump()
            {

            //Vector2(transform.position, y + 5)
               
            }

        public void Score()
    {
        PlayerScore++;
    }
        public void EnemyKilled()
        {
            PlayerScore += 10;
        Debug.Log("Enemy killed");
        }

    }

