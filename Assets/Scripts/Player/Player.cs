using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    float pulo;
    float Jumpforce = 5;
    public float correr;
    private float currentspeed;
    Rigidbody2D minhafisica;
    [SerializeField]
    public float velocidade;
    public Vector2 friction= new Vector2(-.1f,0);


    void Start()
    {
        minhafisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        move();
    }
    void move()
    {
       //moveHorizontal = Input.GetAxis("Horizontal");
         //moveVertical = Input.GetAxis("Vertical");
    if(Input.GetKey(KeyCode.LeftArrow))
       minhafisica.velocity = new Vector2(-currentspeed,minhafisica.velocity.y)*velocidade *Time.deltaTime;

    if(Input.GetKey(KeyCode.RightArrow))
       minhafisica.velocity = new Vector2(currentspeed,minhafisica.velocity.y)*velocidade *Time.deltaTime;

    
    if(minhafisica.velocity.x > 0)
    minhafisica.velocity += friction;                   
if(minhafisica.velocity.x < 0)
    minhafisica.velocity -= friction;

    //correr
     if(Input.GetKey(KeyCode.LeftShift))
        currentspeed = correr;
        else
        {
            currentspeed= velocidade;
        }

    }

    //correr
   

    
    
void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        minhafisica.velocity= Vector2.up* Jumpforce;
    }
}

