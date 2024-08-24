using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerBase : MonoBehaviour
{
    public PlayerObject PlayerManager;


    public string name;
    public float Speed;
    public float Damage;


    private void Start()
    {
        name = PlayerManager.name;
        Speed = PlayerManager.Speed;
        Damage = PlayerManager.Damage;

    }
}
