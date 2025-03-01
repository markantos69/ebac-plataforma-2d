using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    [Header("Pulo")]
    float pulo;
    float Jumpforce = 5;

    [Header("Animacao player")]
    public string boolRun = "Run";
    public Animator animator;

    
    [Header("Velocidade")]
    [SerializeField]
    public float correr;
    private float currentspeed;
    Rigidbody2D minhafisica;
    [SerializeField]
    public float velocidade;
    public Vector2 friction= new Vector2(-.1f,0); //friccao


[Header("ANIMATIONSETUP")]
public float jumpScaley = 1.5f; // pular scale em y
public float animationDuration = .3f;// duracao do scale
public float jumpScalex = .5f; //pular escala ndo em x
public Ease ease = Ease.OutBack;

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
    if(Input.GetKey(KeyCode.LeftArrow)){
    
    
       minhafisica.velocity = new Vector2(-currentspeed,minhafisica.velocity.y)*velocidade *Time.deltaTime;
              minhafisica.transform.localScale = new Vector3(-1,1,1);

        if(minhafisica.transform.localScale.x != -1) 
        minhafisica.transform.DOScaleX(-1,.1f);
                animator.SetBool(boolRun,true);

    
    }
    else if(Input.GetKey(KeyCode.RightArrow))
    {
       minhafisica.velocity = new Vector2(currentspeed,minhafisica.velocity.y)*velocidade *Time.deltaTime;
       minhafisica.transform.localScale = new Vector3(1,1,1);
       if(minhafisica.transform.localScale.x != -1)
        minhafisica.transform.DOScaleX(1,.1f);
    animator.SetBool(boolRun,true); //define boleana run pra true se ele apertar a rigth arrow set pra true
    
    }
    else    animator.SetBool(boolRun,false);

    //friccao
    if(minhafisica.velocity.x > 0)
    minhafisica.velocity += friction;                   
    else if(minhafisica.velocity.x < 0)
    minhafisica.velocity -= friction;
    
    

    //correr
     if(Input.GetKey(KeyCode.LeftShift))
     {
             currentspeed = correr;
            animator.speed = 1.5f;
     }
    

     else
        {
            currentspeed= velocidade;
            animator.speed = 1;
        }
    }


    

    

    

    
   

    
    
void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
        minhafisica.velocity= Vector2.up* Jumpforce;  //pulo
        minhafisica.transform.localScale = Vector2.one ; //reseta tamanho do jogador
        
        DOTween.Kill(minhafisica.transform); //vai matar as animacoes que estverem acontecendo e resetar
        scalejump();
        }

        
    }
    void scalejump() //pra escalar qnd pular
    {
        minhafisica.transform.DOScaleY(jumpScaley,animationDuration).SetLoops(2,LoopType.Yoyo).SetEase(ease); //escala em y 
        minhafisica.transform.DOScaleX(jumpScalex,animationDuration).SetLoops(2,LoopType.Yoyo).SetEase(ease); // escala em x

    }
     
}

