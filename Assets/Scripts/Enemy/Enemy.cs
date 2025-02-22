using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public int demage = 10;
void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.transform.name);
            
            var vida= collision.gameObject.GetComponent<VidaBase>(); // pegar o script vidaBase e colocar ele dentro variavel para checar colisao

            if(vida!= null)
            {
                vida.Demage(demage);
            }
    }
    
    

}
