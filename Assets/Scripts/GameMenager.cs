using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Assets.EBAC.CORE.SINGELTON;
using System.Runtime.CompilerServices;
using DG.Tweening;
public class GameMenager : SINGELTON<GameMenager>
{
    [Header("Player")]
    public GameObject playerPrefab;
    



    [Header("Inimigos")]
    public List<GameObject> inimigos;

[Header("Änimation")]
   public float duration = .2f;
   public float delay = 0.05f;
   public Ease ease = Ease.OutBack;


[Header("references")]
public Transform startPoint;
private GameObject currentPlayer;
    public void Start()
    {
        Init();
    }
    public void Init()
    {
        SpawnPlayer();
    }

    public void SpawnPlayer()
    {
        currentPlayer = Instantiate(playerPrefab);
        currentPlayer.transform.position = startPoint.transform.position;
        currentPlayer.transform.DOScale(0,duration).From();
    }
}