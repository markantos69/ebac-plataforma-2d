using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonsMenager : MonoBehaviour
{
    private const float V = .05f;
    public List<GameObject> buttons;

   [Header("Änimation")]
   public float duration = .2f;
   public float delay = V;
   public Ease ease = Ease.OutBack;
private void HideALLButtons()
{

    foreach(var b in buttons)
    {
        b.transform.localScale=Vector3.zero;
    }
}
   private void showButtons()
   {
for(int i =0; i<buttons.Count; i++)
    {
        var b = buttons[i];
        b.SetActive(true);
        b.transform.DOScale(1,duration).SetDelay(i*delay).SetEase(ease);
    }
}

    private void OnEnable()
    {
        showButtons();
        HideALLButtons();
    }
}

    

