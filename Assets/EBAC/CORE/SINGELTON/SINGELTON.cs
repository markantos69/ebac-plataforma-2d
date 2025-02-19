using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.EBAC.CORE.SINGELTON 
{


public class SINGELTON<T> : MonoBehaviour where T : MonoBehaviour
{

    public static T instance;

    private void Awake()
    {
        
        if(instance== null)
        instance = GetComponent<T>();
        else Destroy(gameObject);
    }

}
}