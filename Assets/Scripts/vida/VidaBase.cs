using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class VidaBase : MonoBehaviour
{
  public int startLife = 10;
  private int currentLife;
private  bool isDead = false;
public bool destroyOnKill = false;
public float delayToKill = 0f;

    void Awake()
    {
        Init();
    }
    private void Init()
    {
        currentLife=startLife;
        isDead = false;

    }

    public void Demage(int demage)
    {
            if(isDead) return;    // se o personagem ta morto ele nao checa o resto do codigo
            currentLife-= demage;

            if (currentLife<= 0 )
            {
                Kill();
            }
    }
    private void Kill()
    {
        isDead= true;

        if(destroyOnKill)
        {
            Destroy(gameObject,delayToKill);
        }
    }
        
}

