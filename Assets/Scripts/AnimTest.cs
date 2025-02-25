using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{
public Animator animator;
public String   triggerToPlay = "ANIM_Astronaut_Jump_Up";


void Update()
{
    if(Input.GetKeyDown(KeyCode.Space));
{
    animator.SetTrigger(triggerToPlay);
}

}
    private void OnValidate()
    {
        if(animator==null) animator.GetComponent<Animator>();
    }
}
